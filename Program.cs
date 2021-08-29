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
           findIndexFibonnaci(1000);
           
        }
        static void findIndexFibonnaci(int digits)
        {
            var num = new BigInteger(2);
            var a = new BigInteger(1);
            var temp = new BigInteger(0);
            int index = 3;
            while (getDigits(num) < digits)
            {
                temp = a;
                a = num;
                num += temp;
                index++;
                Console.WriteLine(num);
            }
            Console.WriteLine(index);
        }
        static int getDigits(BigInteger num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum++;
                num = num / 10;
            }

            return sum;
        }
    }

}

    


