using System;
using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace ProjectEuler.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            Console.WriteLine(findPowersOfTwo(123, 678910));
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
        static long findPowersOfTwo(int L, int n)
        {
            int count = 0;
            long power = 0;
            long num = 2;
            while (count < n)
            {
                power++;
                if (num.ToString().Length >= L.ToString().Length && int.Parse(num.ToString().Substring(0,L.ToString().Length)) == L)
                    count++;
                num *= 2;
                if (num.ToString().Length > L.ToString().Length + 11)
                num /= (long)Math.Pow(10, L.ToString().Length + 2);
            }
            return power;
        }
        //static int[] digits = new int[] { 9,8,7,6,5,4,3,2,1,0};
        //static List<long> perm = new List<long>();
        //static void Rec(int current, int numDigits)
        //{
        //    if (numDigits == 0)
        //    {
        //        perm.Add(long.Parse(current.ToString()));
        //    }
        //    else
        //        foreach (int x in digits)
        //            Rec(current * 10 + x, numDigits - 1);
        //}

    }
}






