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
            findDigitFactorials();
        }
        static void findDigitFactorials()
        {
            int sum = 0;
            for (int i = 3; i<= 2540160; i++)
            {
                if (isSumOfFactorial(i))
                    sum += i;
            }
            Console.WriteLine(sum);
        }

        static bool isSumOfFactorial(int num)
        {
            int sum = 0;
            int n = num;
            while (n!=0)
            {
                sum += getFactorial(n % 10);
                n = n / 10;
            }
            return sum == num;
        }
        static int getFactorial(int num)
        {
            int product = 1;
            for (int i = num; i>1; i--)
            {
                product *= i;
            }
            return product;
        }
    }
}


    


