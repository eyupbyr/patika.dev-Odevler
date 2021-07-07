/*
Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

    Negatif ve numeric olmayan girişleri engelleyin.
    Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
    Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/

using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeList = new ArrayList();
            ArrayList nonPrimeList = new ArrayList();

            int n = 10;
            Console.WriteLine("Enter 20 positive numbers:");
            while(n --> 0)
            {
                int number;
                try
                {                   
                    number = Int32.Parse(Console.ReadLine());
                    if(number < 0)
                        throw new Exception("Negative input can not be accepted.");
                    if(isPrime(number))
                        primeList.Add(number);
                    else 
                        nonPrimeList.Add(number);
                }
                catch (FormatException)
                {
                    throw new Exception("Invalid input!");
                }
            }
            
            primeList.Sort();
            primeList.Reverse();
            nonPrimeList.Sort();
            nonPrimeList.Reverse();

            Console.WriteLine("-----PrimeList-------");
            foreach(int i in primeList)
                Console.WriteLine(i);

            Console.WriteLine("-----NonPrimeList-------");
            foreach(int i in nonPrimeList)
                Console.WriteLine(i);

            int primeListSum = 0;
            int nonPrimeListSum = 0;
            foreach (int i in primeList)
                primeListSum += i;
            foreach (int i in nonPrimeList)
                nonPrimeListSum += i;
            
            Console.WriteLine("Prime Number Count: {0}, Average: {1}", primeList.Count, (float)primeListSum/primeList.Count);
            Console.WriteLine("Non-Prime Number Count: {0}, Average: {1}", nonPrimeList.Count, (float)nonPrimeListSum/nonPrimeList.Count);

            Console.ReadKey();
        }

        static bool isPrime(int number)
        {
            if(number == 1 || number == 0)
                return false;

            for (int i=2; i < number; i++)
                if (number % i == 0) 
                    return false;

            return true;
        }
    }
}
