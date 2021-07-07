/*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/
using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            String input = Console.ReadLine();

            String[] words;
            words = input.Split(" ");
            Console.WriteLine(words.Length);

            int letters = 0;;
            foreach(String s in words)
                letters += s.Length;
            Console.WriteLine(letters);
            
            Console.ReadKey();
        }
    }
}
