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
            Console.WriteLine(findPrimeSpiralUnder10());
        }
        static int findPrimeSpiralUnder10()
        {   
            double length = findPrimeDiagonalSpiral(3,0,1,2,1);
            return (int)length;
        }
        static double findPrimeDiagonalSpiral(int grid,int primeCount, int diagCount, int skip, int a)
        {
            while (true)
            {                
                Console.WriteLine(grid + "," + primeCount + "," + diagCount + "," + skip + "," + a);

                for (int i = 0; i < 4; i++)
                {
                    a += skip;
                    if (isPrime(a))
                    {
                        primeCount++;
                    }
                }

                diagCount += 4; 
                if (((double)primeCount / diagCount) < 0.1000000)
                    return grid; 
                grid += 2;
                skip += 2;
            }
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
    }
}


    


