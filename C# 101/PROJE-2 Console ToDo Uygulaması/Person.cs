using System;

namespace PROJE_2_Console_ToDo_Uygulaması
{
    class Person
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}