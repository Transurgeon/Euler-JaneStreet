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
           Console.WriteLine(findDistinctPrimeFactors(4));
        }

        static List<int> primes = new List<int>();
        static int findDistinctPrimeFactors(int disctint)
        {
            int n = 2;
            while (true)
            {
                if (isPrime(n))
                    primes.Add(n);
                else if (isN_Distinct(disctint,n) && isN_Distinct(disctint,n + 1) && isN_Distinct(disctint, n + 2) && isN_Distinct(disctint, n + 3))
                    return n;
                n++;
            }
        }
        static bool isN_Distinct(int disctint, int num)
        {
            int factorCount = 0;
            for (int i = 0; i<primes.Count; i++)
            {
                if (num %  primes[i] == 0) {
                    do
                    {
                        num = num / primes[i];
                    } while (num % primes[i] == 0);
                    factorCount++;
                }
            }
            if (factorCount == disctint)
                return true;
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


    


