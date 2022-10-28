using System;
using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;

namespace ProjectEuler.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            //this is for reading txt files
            //string path = @"C:\Users\Admin\source\repos\ProjectEuler.Net\Problems 61-70\p054_poker.txt";

            //List<string> lines = new List<string>();
            //lines = File.ReadAllLines(path).ToList();
            //String input = "";
            //foreach (String line in lines)
            //{
            //    input += line + "\n";
            //} 
            //comment out till here if no need :)
            watch.Start();
            Console.WriteLine(getPartitions(100));
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
        static long getPartitions(int n)
        {
            List<long> parts = new List<long>();
            List<long> shift = new List<long>();
            long a = 1;shift.Add(a);
            long c = 1;parts.Add(c);
            long odd = 1;
            long even = 3;
            while (a <= n) {
                if (shift.Count % 2 == 1) {
                    shift.Add(a + odd);
                    a += odd;
                    odd++;
                }
                else
                {
                    shift.Add(a + even);
                    a += even;
                    even += 2;
                }
            }
            for (int i = 1; i<=n; i++)
            {
                c = incrementPartitions(i, shift, parts);
                parts.Add(c);
                Console.WriteLine(i+","+c);
            }
            return parts[n]-1;
        }
        static long incrementPartitions(int n, List<long> shift, List<long> parts)
        {
            int count = maxPosition(n, shift);
            long c = 0;
            for (int i = 0; i < count; i++)
            {
                if (i % 4 == 0 || i % 4 == 1)
                {
                    c += parts[parts.Count - (int)shift[i]];
                }

                else if (i % 4 == 2 || i % 4 == 3)
                {
                    c-= parts[parts.Count - (int)shift[i]];
                }
            }
            return c;
        }

        static int maxPosition(int n, List<long> shift)
        {
            for (int i = 0; i<shift.Count; i++)
            {
                if (shift[i] > n)
                {
                    return i;
                }
            }
            return 0;
        }
        //static long emod(long a, long b, long c)
        /*{
            if (b == 0)
                return 1;
            else if (b % 2 == 0)
            {
                long d = emod(a, b / 2, c);
                return (d * d) % c;
            }
            else
                return ((a % c * emod(a, b - 1, c)) % c);
        } */
        //static int[] digits = new int[] { 9,8,7,6,5,4,3,2,1,0};
        //static List<long> perm = new List<long>();
        //static void Rec(int current, int numDigits)
        /*{
            if (numDigits == 0)
            {
                perm.Add(long.Parse(current.ToString()));
            }
            else
                foreach (int x in digits)
                    Rec(current* 10 + x, numDigits - 1);
           } */

    }
}