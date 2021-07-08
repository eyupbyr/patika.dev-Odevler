using System;
using System.Collections.Generic;

namespace PROJE_1_Console_Telefon_Rehberi_Uygulaması
{
    public static class PhoneBook
    {
        public static List<Person> phoneBook = new List<Person>();
        public static void Add(Person person)
        {
            phoneBook.Add(person);
        }

        public static void Delete(String input)
        {
            foreach (Person person in phoneBook)
            {
                if (input.ToUpper() == person.Name.ToUpper() || input.ToUpper() == person.Surname.ToUpper())
                {
                    phoneBook.Remove(person);
                    Console.WriteLine("Kayıt silindi!");
                    return;
                }
            }

            //eğer yukarıda fonksiyon sonlanmazsa:
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n"
                             +"* Silmeyi sonlandırmak için : (1)\n"
                             +"* Yeniden denemek için      : (2)\n");

            int choice = Int32.Parse(Console.ReadLine());
            if(choice == 1)
                return;
            else if(choice == 2)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                input = Console.ReadLine();
                PhoneBook.Delete(input);
            }
        }

        public static void Update(String input)
        {
            foreach (Person person in phoneBook)
            {
                if (input.ToUpper() == person.Name.ToUpper() || input.ToUpper() == person.Surname.ToUpper())
                {
                    Console.WriteLine("Yeni telefon numarasını giriniz:");
                    person.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Kayıt güncellendi!");
                    return;
                }
            }

            //eğer yukarıda fonksiyon sonlanmazsa:
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n"
                             +"* Güncellemeyi sonlandırmak için : (1)\n"
                             +"* Yeniden denemek için      : (2)\n");

            int choice = Int32.Parse(Console.ReadLine());
            if(choice == 1)
                return;
            else if(choice == 2)
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                input = Console.ReadLine();
                PhoneBook.Update(input);
            }
        }

        public static void List()
        {
            Console.WriteLine("Telefon Rehberi\n"
                             +"**********************************************");
            foreach(Person person in phoneBook)
            {
                Console.WriteLine("İsim: " + person.Name);
                Console.WriteLine("Soyisim: " + person.Surname);
                Console.WriteLine("Telefon Numarası: " + person.PhoneNumber);
                Console.WriteLine("-");
            }
        }

        public static void Search(string input, int searchMode)
        {
            bool isFound = false;

            Console.WriteLine("Arama Sonuçlarınız\n"
                             +"**********************************************");

            //search by name(or surname)
            if(searchMode == 1)
            {
                foreach (Person person in phoneBook)
                {
                    if (input.ToUpper() == person.Name.ToUpper() || input.ToUpper() == person.Surname.ToUpper())
                    {
                        Console.WriteLine("İsim: " + person.Name);
                        Console.WriteLine("Soyisim: " + person.Surname);
                        Console.WriteLine("Telefon Numarası: " + person.PhoneNumber);
                        Console.WriteLine("-");
                        isFound = true;
                    }
                }
            }

            //search by phoneNumber
            else if(searchMode == 2)
            {
                foreach (Person person in phoneBook)
                {
                    if (input == person.PhoneNumber)
                    {
                        Console.WriteLine("İsim: " + person.Name);
                        Console.WriteLine("Soyisim: " + person.Surname);
                        Console.WriteLine("Telefon Numarası: " + person.PhoneNumber);
                        Console.WriteLine("-");
                        isFound = true;
                    }
                }
            }

            if(!isFound)
                Console.WriteLine("Kayıt Bulunamadı");
        }
    }
}