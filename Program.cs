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
            Console.WriteLine(findNextTPH_Num());
        }
        static bool isPentagonal(long Pn)
        {
            return (1 + Math.Sqrt(1+24*Pn))/6 - Math.Floor((1 + Math.Sqrt(1 + 24 * Pn)) / 6) < 0.0000001;
        }
        static bool isTriangular(long Tn)
        {
            return (-1 + Math.Sqrt(1 + 8 * Tn)) / 2 - Math.Floor((-1 + Math.Sqrt(1 + 8 * Tn)) / 2) < 0.0000001;
        }
        static bool isHexagonal(long Tn)
        {
            return ((Math.Sqrt(1 + 8 * Tn))+1) / 4 - Math.Floor(((Math.Sqrt(1 + 8 * Tn))+1) / 4) < 0.0000001;
        }

        static long findNextTPH_Num()
        {
            long n = 40756;
            while (true)
            {
                if (isTriangular(n) && isPentagonal(n) && isHexagonal(n))
                    return n;
                n++;
            }
        }
    }
}


    


