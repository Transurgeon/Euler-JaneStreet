using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_71_80
{
    class Problem76
    {
        /* 
         * Formula derived by Euler himself. Links to pentagonal numbers
         * Link to video for source of inspiration : https://www.youtube.com/watch?v=D9-voINFkCg (algorithm is literally given)
         * This was a very fun problem which led me to diving deeper into the world of partitions and the works of Euler and Ramanujan
         * 
         * static void Main(string[] args)
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
        }*/
    }
}
