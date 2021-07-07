/*
Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
*/
using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Console.WriteLine("Enter 20 numbers.");
            for (int i = 0; i < 20; i++)
            {
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            int smallestThreeSum = numbers[0]+numbers[1]+numbers[2];
            int biggestThreeSum = numbers[numbers.Length-1]+numbers[numbers.Length-2]+numbers[numbers.Length-3];

            Console.WriteLine("Smallest 3 three numbers: {0} {1} {2}  Average: {3}",numbers[0],numbers[1],numbers[2],(float)smallestThreeSum/3);

            Console.WriteLine("Biggest 3 three numbers: {0} {1} {2}  Average: {3}",numbers[numbers.Length-1],numbers[numbers.Length-2],numbers[numbers.Length-3],(float)biggestThreeSum/3);

            Console.ReadKey();
        }
    }
}
