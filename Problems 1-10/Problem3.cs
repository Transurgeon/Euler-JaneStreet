using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net
{
    class Problem3
    {
        /*
        static void Main(string[] args)
        {

            FindLargestPrimeFactor(600851475143);

        }

        static void FindLargestPrimeFactor(long a)
        {
            long buffer = 0; 
            long number = a;
            do
            {
                buffer = FindSmallestPrime(number);
                number = number / buffer;
            } while (buffer != 1);

            Console.WriteLine(number);
        }
        static long FindSmallestPrime(long a)
        {
            if (a % 2 == 0)
                return 2;
            for (long i = 3; i <= Math.Sqrt(a); i+=2)
            {
                if (a % i == 0)
                {
                    return i;

                }
            }
            return 1;
        }*/
    }
}
