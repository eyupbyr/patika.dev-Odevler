using System;

namespace PROJE_2_Console_ToDo_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            int choice;
            do
            {
                Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :)\n" 
                             +"*******************************************\n"
                             +"(1) Board Listelemek\n"
                             +"(2) Board'a Kart Eklemek\n"
                             +"(3) Board'dan Kart Silmek\n"
                             +"(4) Kart Taşımak\n"
                             +"(0) Çıkış\n");
                choice = Int32.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        board.ListBoard();
                        break;

                    case 2:
                        board.AddCard();
                        break;

                    case 3:
                        board.DeleteCard();
                        break;

                    case 4:
                        board.MoveCard();
                        break;

                    default:
                        break;
                }
            } while (choice != 0);
        }
    }
}
