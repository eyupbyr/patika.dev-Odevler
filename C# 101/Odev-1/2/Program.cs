/*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/

using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers!");
            int n = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + n + " numbers!");
            int[] numbers = new int[n];
            for(int i = 0; i < n; i++)
                numbers[i] = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Result:");
            for(int i = 0; i < n; i++)
                if(m % numbers[i] == 0)
                    Console.WriteLine(numbers[i]);

            Console.ReadKey();

        }
    }
}
