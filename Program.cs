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
            
            findSubStringDivisibility();
            //Console.WriteLine(isSubDivisible("1406357829",primes));
        }
        static void findSubStringDivisibility()
        {
            long sum = 0;
            long[] primes = { 2, 3, 5, 7, 11, 13, 17 };
            for (long i = 1000000000; i<9876543210; i++)
            {
                if (isPandigital(i.ToString()) && isSubDivisible(i.ToString(),primes))
                {
                        Console.WriteLine(sum + "," + i);
                        sum += i;
                }
            }
            Console.WriteLine(sum);
        }
        static bool isPandigital(String concat)
        {
            int length = concat.Length;
            for (int i = 0; i <= 9; i++)
            {
                concat = concat.Replace(i.ToString(), "");
                length--;
                if (concat.Length != length)
                    return false;
            }
            return true;
        }

        static bool isSubDivisible(String num, long[] primes)
        {
            for (int j = 2; j <= 8; j++)
            {
                if (long.Parse(num.Substring(j - 1, 3)) % primes[j - 2] != 0)
                    return false;
            }
            return true;
        }
    }
}


    


