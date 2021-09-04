using System;
using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findGoldBachConjecture());
        }

        static long findGoldBachConjecture()
        {
            long n = 9;
            while (true)
            {
                if (!isGoldBach(n))
                    return n;
                n+= 2;
            }
        }

        static bool isGoldBach(long num)
        {
            if (isPrime(num))
                return true;
            List<long> primes = new List<long>();
            for (long i = 2; i<=num; i++)
            {
                if (isPrime(i))
                {
                    if (((Math.Sqrt((num - i) / 2)) - Math.Floor(Math.Sqrt((num - i) / 2))) < 0.0000001)
                        return true;
                }   
            }
            return false;
        }
        static Boolean isPrime(long a)
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
        }
    }
}


    


