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
            findSumDiagonalSpiral(1001);
        }
        static void findSumDiagonalSpiral(int grid)
        {
            var sum = new BigInteger(1);
            int count = 0;
            int skip = 2;
            int a = 3;
            while (a <= grid * grid)
            { 
                count++;
                if (count == 4)
                {
                    count = 0;
                    skip += 2;
                    Console.WriteLine(skip);
                }
                sum += a;
                a += skip;
               
            }
            Console.WriteLine(sum);

        }
    }
}


    


