using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems
{
    class Problem7
    {
        /*  static void Main(string[] args)
        {
            Find_Nth_Primes(10001);
            //Console.WriteLine(isPrime(9));
        }

        static void Find_Nth_Primes(int high)
        {
            int count = 0;
            long bigPrime = 0;
            long a = 3;
            do
            { 
                bigPrime = a;
                if (isPrime(a) == true)
                {
                    count++;
                    Console.WriteLine(a);
                }
                 a += 2;
            } while (count < high);

            Console.WriteLine(bigPrime);
        }

        static Boolean isPrime(long a)
        {
            if (a % 2 == 0)
                return false;
            for (long i = 3; i <= Math.Sqrt(a); i +=2)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        } */
    }
}
