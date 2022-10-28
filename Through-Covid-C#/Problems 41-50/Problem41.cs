using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_41_50
{
    class Problem41
    {
        /*         static void Main(string[] args)
        {
            findPandigitalPrime();
           
        }
        static void findPandigitalPrime()
        {
            long largest = 2;
            for (long i = 1; i<=7654321; i+=2)
            {

                if (isPrime(i) && isPandigital(i.ToString()))
                {
                    Console.WriteLine(i);
                    largest = i;
                }
            }
            Console.WriteLine(largest);
        }
        static bool isPandigital(String concat)
        {
            if (concat.Contains('0'))
                return false;
            int length = concat.Length;
            for (int i = concat.Length; i > 0; i--)
            {
                concat = concat.Replace(i.ToString(), "");
                length--;
                if (concat.Length != length)
                    return false;
            }
            return true;
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
        }*/
    }
}
