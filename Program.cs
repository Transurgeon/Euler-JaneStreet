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
            Console.WriteLine(findVeryLargeNon_Mersenne(28433,7830457));
        }

        static long findVeryLargeNon_Mersenne(int product, int power)
        {
            long num = 1;
            for (int i = 0; i < power;i++)
            {
                num *= 2;
                num = num % 10000000000;
            }
            num *= product;
            num = num % 10000000000;
            num++;
            return num;
        }
    }
}


    


