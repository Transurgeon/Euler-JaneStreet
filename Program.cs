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
            Console.WriteLine(findLychrelNumbers(10000));
        }

        static int findLychrelNumbers(int high)
        {
            int countLychrel = 0; 
            for (int i = 1; i<high; i++)
            {
                int iterations = 0;
                var n = new BigInteger(i);
                while (iterations < 50)
                {
                    if (!isPalyndrome(n + getReverse(n)))
                    {
                        n = n + getReverse(n);
                        iterations++;
                    }
                    else break;
                    if (iterations == 49)
                        countLychrel++;
                   
                }
            }
            return countLychrel;
        }
        static Boolean isPalyndrome(BigInteger a)
        {
            String reverse = "";
            String num = a.ToString();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                reverse += num[i];
            }
            if (reverse.Equals(num))
                return true;
            return false;
        }
        static BigInteger getReverse(BigInteger a)
        {
            String reverse = "";
            String num = a.ToString();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                reverse += num[i];
            }
            return BigInteger.Parse(reverse);
        }
    }
}


    


