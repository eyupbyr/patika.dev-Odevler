/*
Soru - 3:
Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
*/
using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeıouAEIOU";
            int count = 0;

            Console.WriteLine("Enter the sentence:");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
                for (int j = 0; j < vowels.Length; j++)
                    if (input[i] == vowels[j])
                        count++;

            char[] vowelArray = new char[count];

            int index = 0;
            for (int i = 0; i < input.Length; i++)
                for (int j = 0; j < vowels.Length; j++)
                    if (input[i] == vowels[j])
                    {
                        vowelArray[index] = input[i];
                        index++;
                    }

            Array.Sort(vowelArray);

            foreach (var i in vowelArray)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
