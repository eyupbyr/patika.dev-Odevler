using System;

namespace PROJE_2_Console_ToDo_Uygulaması
{
    class Card
    {
        private string header;
        private string content;
        private Person assignedPerson;
        private Size size;

        public string Header { get => header; set => header = value; }
        public string Content { get => content; set => content = value; }
        public Person AssignedPerson { get => assignedPerson; set => assignedPerson = value; }
        public Size Size { get => size; set => size = value; }

        public Card(string header, string content, Person assignedPerson, Size size)
        {
            this.header = header;
            this.content = content;
            this.assignedPerson = assignedPerson;
            this.size = size;
        }
    }
}