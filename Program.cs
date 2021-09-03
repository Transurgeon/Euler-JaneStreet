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
            findChampernowne();

        }
        static void findChampernowne()
        {
            int count = 1;
            int digitCount = 1;
            int powerDigit = 0;
            int product = 1;
            while (digitCount <= 1000010)
            {
                if (digitCount >= (int)Math.Pow(10, powerDigit))
                {
                    product *= int.Parse(count.ToString().Substring((int)(digitCount - Math.Pow(10, powerDigit)),1));
                    powerDigit++;
                }
                
                digitCount += count.ToString().Length;
                count++;
            }
            Console.WriteLine(product);
        }

    }
}


    


