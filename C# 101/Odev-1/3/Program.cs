/*
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
*/
using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + n + " word(s)!");
            String[] words = new String[n];

            for(int i = 0; i < n; i++)
                words[i] = Console.ReadLine();

            Console.WriteLine("Reverse order:");
            for(int i = n-1; i >= 0; i--)
                Console.WriteLine(words[i]);

            Console.ReadKey();
        }
    }
}
