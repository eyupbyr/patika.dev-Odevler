using System;

namespace PROJE_1_Console_Telefon_Rehberi_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook.Add(new Person("Ahmet","Yılmaz","05365467892"));
            PhoneBook.Add(new Person("Mehmet","Celik","05365467892"));
            PhoneBook.Add(new Person("Ayse","Demir","05365467892"));
            PhoneBook.Add(new Person("Fatma","Turan","05365467892"));
            PhoneBook.Add(new Person("Omer","Seckin","05365467892"));

            int choice;
            string name, surname, phoneNumber;
            string input;

            do
            {
                Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :)\n" 
                             +"*******************************************\n"
                             +"(1) Yeni Numara Kaydetmek\n"
                             +"(2) Varolan Numarayı Silmek\n"
                             +"(3) Varolan Numarayı Güncelleme\n"
                             +"(4) Rehberi Listelemek\n"
                             +"(5) Rehberde Arama Yapmak\n"
                             +"(0) Çıkış\n");
                choice = Int32.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Lütfen isim giriniz             :");
                        name = Console.ReadLine();
                        Console.WriteLine("Lütfen soyisim giriniz          :");
                        surname = Console.ReadLine();
                        Console.WriteLine("Lütfen telefon numarası giriniz :");
                        phoneNumber = Console.ReadLine();

                        PhoneBook.Add(new Person(name,surname,phoneNumber));
                        break;

                    case 2:
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                        input = Console.ReadLine();

                        PhoneBook.Delete(input);
                        break;

                    case 3:
                        Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                        input = Console.ReadLine();

                        PhoneBook.Update(input);
                        break;

                    case 4:
                        PhoneBook.List();
                        break;
                    
                    case 5:
                        Console.WriteLine("\nİsim veya soyisime göre arama yapmak için: (1)"
                                         +"\nTelefon numarasına göre arama yapmak için: (2)");

                        int searchMode = Int32.Parse(Console.ReadLine());
                        if(searchMode == 1)
                            Console.WriteLine("\nİsim veya soyismi giriniz.");
                        else
                            Console.WriteLine("\nTelefon numarasını giriniz.");
                            
                        input = Console.ReadLine();

                        PhoneBook.Search(input, searchMode);
                        break;

                    default:
                        break;
                }
            } while (choice != 0);

        }
        
    }
}
