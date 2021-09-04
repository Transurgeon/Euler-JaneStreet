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
            Console.WriteLine(findSelfPowers(1000));
        }

        static BigInteger findSelfPowers(int n)
        {
            var sum = new BigInteger(0);
            for (int i = 1; i<=n; i++)
            {
                sum += multiplyMod(i);
                Console.WriteLine(i+","+sum);
            }
            return sum % 10000000000;
        }

        static BigInteger multiplyMod(int num)
        {
            BigInteger product = 1;
            for (int i = 1; i<=num; i++)
            {
                product *= num;
                product = product % 10000000000;
            }
            return product;
        }
    }
}


    


