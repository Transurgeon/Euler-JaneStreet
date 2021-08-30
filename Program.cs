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
            findLongestQuadraticPrimes(1000);
            //Console.WriteLine(getLongestPrimeSeq(-79, 1601));
        }
        static void findLongestQuadraticPrimes(int limit)
        {
            int largest = 0;
            int a = 0; int b = 0;
           for (int i = 1; i < limit; i+=2)
            {
                for (int j = 1; j < limit; j +=2)
                {
                    if (getLongestPrimeSeq(-i,j) > largest)
                    {
                        a = -i; b = j;
                        largest = getLongestPrimeSeq(-i, j);
                        Console.WriteLine((a * b) + ", " + a + ", " + b + ", " + largest);
                    }
                    else if (getLongestPrimeSeq(i, j) > largest)
                    {
                        a = i; b = j;
                        largest = getLongestPrimeSeq(i, j);
                        Console.WriteLine((a * b) + ", " + a + ", " + b + ", " + largest);
                    }
                }
            }
            Console.WriteLine((a*b)+", "+ a + ", " + b + ", " + largest);
        }
        
        static int getLongestPrimeSeq(int a, int b)
        {
            int n = 0;
            do
            {
                if (isPrime(n * n + n * a + b))
                    n++;
                else
                    return n;

            } while (true);
        }
        static Boolean isPrime(long a)
        {
            if (a < 0)
                return false;
            if (a % 2 == 0)
                return false;
            for (long i = 3; i <= Math.Sqrt(a); i += 2)
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

    


