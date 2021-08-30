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
            findLongestRecurringCycle(1000);
            //Console.WriteLine(findRecurringCycle(3));
        }
        static void findLongestRecurringCycle(int limit)
        {
            int largest = 2;
            int largestCycle = 0;
            for (int i = 2; i<=limit; i++)
            {
                if (i % 2 != 0 && i % 5 != 0)
                {
                    if (findRecurringCycle(i) > largestCycle) { 
                    largest = i; 
                    largestCycle = findRecurringCycle(largest);
                    Console.WriteLine(i + ", " + largestCycle);
                    }
                }
                
            }
            Console.WriteLine(largest);
        }
        
        static int findRecurringCycle (BigInteger num)
        {
            int n = 1;
            while (true)
            {
                if ((BigInteger.Pow(10, n) - 1) % num == 0) 
                    return n;
                n++;
            }
        }
    }

}

    


