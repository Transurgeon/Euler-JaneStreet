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
           findTruncatablePrimes();
            //Console.WriteLine(isTruncatedPrime(3797));
        }
        static void findTruncatablePrimes()
        {
            long sum = 0;
            int count = 0;
            int n = 8;
            while (count < 11)
            {
                if (isPrime(n))
                {
                    if (isTruncatedPrime(n))
                    {
                        Console.WriteLine(n);
                        sum += n;
                        count++;
                    }
                }
                n++;
            }
            Console.WriteLine(sum);
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
        static bool isTruncatedPrime(int num)
        {
            int high = (int)Math.Log10(num);
            long right; long left;
            for (int i = 1; i<=high; i++)
            {
                right = num % (int)Math.Pow(10, i);
               // Console.WriteLine(right);
                if (!isPrime(right))
                    return false;
            }
            for (int i = high; i>0; i--)
            {
                left = num / (int)Math.Pow(10, i);
               // Console.WriteLine(left);
                if (!isPrime(left))
                    return false;
            }
            return true;
        }
    }
}


    


