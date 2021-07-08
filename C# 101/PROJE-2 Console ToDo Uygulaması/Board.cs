using System;
using System.Collections.Generic;
using System.Linq;

namespace PROJE_2_Console_ToDo_Uygulaması
{
    class Board
    {
        private List<Card> todoCards = new List<Card>();
        private List<Card> inProgressCards = new List<Card>();
        private List<Card> doneCards = new List<Card>();

        public List<Card> TodoCards { get => todoCards; set => todoCards = value; }
        public List<Card> InProgressCards { get => inProgressCards; set => inProgressCards = value; }
        public List<Card> DoneCards { get => doneCards; set => doneCards = value; }

        private List<Person> teamMembers = new List<Person>();

        public Board()
        {
            teamMembers.Add(new Person(1,"Ahmet"));
            teamMembers.Add(new Person(2,"Furkan"));
            teamMembers.Add(new Person(3,"Zeynep"));
            teamMembers.Add(new Person(4,"Murat"));
            teamMembers.Add(new Person(5,"Ali"));
            teamMembers.Add(new Person(6,"Ayşe"));
            teamMembers.Add(new Person(7,"Omer"));
            teamMembers.Add(new Person(8,"Fatma"));

            TodoCards.Add(new Card("Header1","Content1", teamMembers[1],Size.M));
            InProgressCards.Add(new Card("Header2","Content2", teamMembers[2],Size.XL));
            InProgressCards.Add(new Card("Header3","Content3", teamMembers[3],Size.S));
        }
        
        public void ListBoard()
        {
            bool isFound = false;

            Console.WriteLine("TODO Line\n"
                             +"************************\n");
            foreach(Card card in TodoCards)
            {
                isFound = true;
                Console.WriteLine("Başlık      :\t" + card.Header);
                Console.WriteLine("İçerik      :\t" + card.Content);
                Console.WriteLine("Atanan Kişi :\t" + card.AssignedPerson.Name);
                Console.WriteLine("Büyüklük    :\t" + card.Size);
                Console.WriteLine("-");
            }
            if(!isFound)
                Console.WriteLine(" ~ BOŞ ~\n");
            isFound = false;

            Console.WriteLine("IN PROGRESS Line\n"
                             +"************************\n");
            foreach(Card card in InProgressCards)
            {
                isFound = true;
                Console.WriteLine("Başlık      :\t" + card.Header);
                Console.WriteLine("İçerik      :\t" + card.Content);
                Console.WriteLine("Atanan Kişi :\t" + card.AssignedPerson.Name);
                Console.WriteLine("Büyüklük    :\t" + card.Size);
                Console.WriteLine("-");
            }
            if(!isFound)
                Console.WriteLine(" ~ BOŞ ~\n");
            isFound = false;

            Console.WriteLine("DONE Line\n"
                             +"************************\n");
            foreach(Card card in DoneCards)
            {
                isFound = true;
                Console.WriteLine("Başlık      :\t" + card.Header);
                Console.WriteLine("İçerik      :\t" + card.Content);
                Console.WriteLine("Atanan Kişi :\t" + card.AssignedPerson.Name);
                Console.WriteLine("Büyüklük    :\t" + card.Size);
                Console.WriteLine("-");
            }
            if(!isFound)
                Console.WriteLine(" ~ BOŞ ~\n");
        }

        public void AddCard()
        {
            Console.WriteLine("\nBaşlık Giriniz                                  :");
            string header = Console.ReadLine();
            Console.WriteLine("\nİçerik Giriniz                                  :");
            string content = Console.ReadLine();
            Console.WriteLine("\nBüyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            Size size = (Size)Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nKişi Seçiniz                                    :");
            int ID = Int32.Parse(Console.ReadLine());

            foreach(Person person in teamMembers)
            {
                if(person.Id == ID)
                {
                    todoCards.Add(new Card(header,content,person,size));
                    Console.WriteLine("Kart Eklendi!\n");
                    return;
                }
            }

            Console.WriteLine("Hatalı girişler yaptınız!");
            return;

        }

        public void DeleteCard()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\n"
                             +"Lütfen kart başlığını yazınız:");
            string header = Console.ReadLine();

            bool isCardFound = false;
            
            foreach (Card card in TodoCards.ToList())
            {
                if(card.Header.Equals(header))
                {
                    TodoCards.Remove(card);
                    isCardFound = true;
                }
            }

            foreach (Card card in InProgressCards.ToList())
            {
                if(card.Header.Equals(header))
                {
                    InProgressCards.Remove(card);
                    isCardFound = true;
                }
            }

            foreach (Card card in DoneCards.ToList())
            {
                if(card.Header.Equals(header))
                {
                    DoneCards.Remove(card);
                    isCardFound = true;
                }
            }

            if(!isCardFound)
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n"
                             +"* Silmeyi sonlandırmak için : (1)\n"
                             +"* Yeniden denemek için      : (2)\n");

                int choice = Int32.Parse(Console.ReadLine());
                if(choice == 1)
                    return;
                else if(choice == 2)
                    DeleteCard();
            }
        }

        public void MoveCard()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.\n"
                             +"Lütfen kart başlığını yazınız:");
            string header = Console.ReadLine();

            foreach (Card card in TodoCards)
            {
                if(card.Header.Equals(header))
                {
                    Console.WriteLine("Bulunan kart bilgileri\n"
                             +"************************\n");
                    Console.WriteLine("Başlık      :\t" + card.Header);
                    Console.WriteLine("İçerik      :\t" + card.Content);
                    Console.WriteLine("Atanan Kişi :\t" + card.AssignedPerson.Name);
                    Console.WriteLine("Büyüklük    :\t" + card.Size);
                    Console.WriteLine("Line        :\t" + "TODO Line");

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:\n" 
                                     +"(1) TODO\n"
                                     +"(2) IN PROGRESS\n"
                                     +"(3) DONE\n");

                    int input = Int32.Parse(Console.ReadLine());

                    if(input == 1)
                    {
                        //aynı line da olduğu için bir taşıma yapmaya gerek yok
                        Console.WriteLine("Taşıma işlemi başarılı!\n");
                        return;
                    }
                    else if(input == 2)
                    {
                        TodoCards.Remove(card);
                        InProgressCards.Add(card);
                        Console.WriteLine("Taşıma işlemi başarılı!\n");
                        return;
                    }
                    else if(input == 3)
                    {
                        TodoCards.Remove(card);
                        DoneCards.Add(card);
                        Console.WriteLine("Taşıma işlemi başarılı!\n");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı bir seçim yaptınız!");
                        return;
                    }

                }
            }

            foreach (Card card in InProgressCards)
            {
                if(card.Header.Equals(header))
                {
                    Console.WriteLine("Bulunan kart bilgileri\n"
                             +"************************\n");
                    Console.WriteLine("Başlık      :\t" + card.Header);
                    Console.WriteLine("İçerik      :\t" + card.Content);
                    Console.WriteLine("Atanan Kişi :\t" + card.AssignedPerson.Name);
                    Console.WriteLine("Büyüklük    :\t" + card.Size);
                    Console.WriteLine("Line        :\t" + "IN PROGRESS Line");

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:\n" 
                                     +"(1) TODO\n"
                                     +"(2) IN PROGRESS\n"
                                     +"(3) DONE\n");
                    
                    int input = Int32.Parse(Console.ReadLine());

                    if(input == 1)
                    {
                        InProgressCards.Remove(card);
                        TodoCards.Add(card);
                    }
                    else if(input == 2)
                    {
                        //aynı line da olduğu için bir taşıma yapmaya gerek yok
                        Console.WriteLine("Taşıma işlemi başarılı!\n");
                        return;
                    }
                    else if(input == 3)
                    {
                        InProgressCards.Remove(card);
                        DoneCards.Add(card);
                        Console.WriteLine("Taşıma işlemi başarılı!\n");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı bir seçim yaptınız!");
                        return;
                    }
                }
            }

            foreach (Card card in DoneCards)
            {
                if(card.Header.Equals(header))
                {
                    Console.WriteLine("Bulunan kart bilgileri\n"
                             +"************************\n");
                    Console.WriteLine("Başlık      :\t" + card.Header);
                    Console.WriteLine("İçerik      :\t" + card.Content);
                    Console.WriteLine("Atanan Kişi :\t" + card.AssignedPerson.Name);
                    Console.WriteLine("Büyüklük    :\t" + card.Size);
                    Console.WriteLine("Line        :\t" + "DONE Line");

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:\n" 
                                     +"(1) TODO\n"
                                     +"(2) IN PROGRESS\n"
                                     +"(3) DONE\n");
                    
                    int input = Int32.Parse(Console.ReadLine());

                    if(input == 1)
                    {
                        TodoCards.Remove(card);
                        DoneCards.Add(card);
                        Console.WriteLine("Taşıma işlemi başarılı!\n");
                        return;
                    }
                    else if(input == 2)
                    {
                        InProgressCards.Remove(card);
                        DoneCards.Add(card);
                        Console.WriteLine("Taşıma işlemi başarılı!\n");
                        return;
                    }
                    else if(input == 3)
                    {
                        //aynı line da olduğu için bir taşıma yapmaya gerek yok
                        Console.WriteLine("Taşıma işlemi başarılı!\n");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı bir seçim yaptınız!");
                        return;
                    }
                }
            }

            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n"
                             +"* İşlemi sonlandırmak için  : (1)\n"
                             +"* Yeniden denemek için      : (2)\n");

                int choice = Int32.Parse(Console.ReadLine());
                if(choice == 1)
                    return;
                else if(choice == 2)
                    MoveCard();
        }
    }
}