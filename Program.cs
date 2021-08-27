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
            getFactorialDigits(100);
            
        }
        static void getFactorialDigits(int input)
        {
            var product = new BigInteger(1);
            var sum = new BigInteger(0);
            for (int i = 2; i<=input; i++)
            {
                product *= i;
            }

            while (product != 0)
            {
                sum += product % 10;
                product = product / 10;
            }
            Console.WriteLine(sum);
        }
   
    }

}

    


