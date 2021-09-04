using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_41_50
{
    class Problem44
    {
        /*        static void Main(string[] args)
        {

            Console.WriteLine(findPentagonalDifference());
           
        }
        static long P(long n)
        {
            return (3 * n * n - n)/2;
        }
        static bool isPentagonal(long Pn)
        {
            return (1 + Math.Sqrt(1+24*Pn))/6 - Math.Floor((1 + Math.Sqrt(1 + 24 * Pn)) / 6) < 0.0001;
        }
        static long findPentagonalDifference()
        {
            long n = 2;
            long lowest = 100000000;
            bool brake = false; 
            long i;
            while (!brake)
            {
                brake = true;
                i = n - 1;
                while(P(n)-P(i) < lowest && i >= 1)
                { 
                    if (isPentagonal(P(n) - P(i)) && isPentagonal(P(n) + P(i)))
                    {
                        lowest = P(n) - P(i);
                        Console.WriteLine(n + "," + i + "," + P(n) + "," + P(i));
                    }
                    brake = false;
                    i--;
                }
                n++;
            }
            return lowest;
        } */
    }
}
