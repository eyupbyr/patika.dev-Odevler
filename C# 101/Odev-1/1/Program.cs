/*
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
*/

using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of integers");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the integers");
            int[] integers = new int[n];
            for(int i = 0; i < n; i++)
            {
                integers[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Even integers");
            for(int i = 0; i < n; i++)
            {
                if(integers[i] % 2 == 0)
                    Console.WriteLine(integers[i]);
            }

            Console.ReadKey(); 
        }
    }
}
