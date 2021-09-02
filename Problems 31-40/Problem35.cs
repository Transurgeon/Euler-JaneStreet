using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_31_40
{
    class Problem35
    {
        /*         static void Main(string[] args)
        {
             findCircularPrimes(1000000);
           //Console.WriteLine( isCircularPrime(29));
        }
        static void findCircularPrimes(int limit)
        {
            int count = 0;
            int j = 0;
            for (int i = 2; i < limit; i++)
            {
                if (isPrime(i))
                {
                    if (isCircularPrime(i))
                      count++;
                }
            }
            Console.WriteLine(count);
        }

        static bool isCircularPrime(int prime)
        {
            if (!isPrime(prime))
                return false;
            if (prime < 10)
                return true;
            int length = (int)Math.Log10(prime);
            int i = (prime % 10) * (int)Math.Pow(10, length) + prime/10;
            do
            {
                if (!isPrime(i))
                    return false;
                i = (i % 10) * (int)Math.Pow(10, length) + i / 10;
            } while (i != prime);
            return true;
        }
        static Boolean isPrime(int a)
        {
            if (a < 2)
                return false;
            if (a % 2 == 0 && a != 2)
                return false;
            for (int i = 3; i <= Math.Sqrt(a); i += 2)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }*/
    }
}
