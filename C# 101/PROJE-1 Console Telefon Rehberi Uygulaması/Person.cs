using System;

namespace PROJE_1_Console_Telefon_Rehberi_Uygulaması
{
    public class Person
    {
        private string name;
        private string surname;
        private string phoneNumber;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Person(string name, string surname, string phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }
    }
}