using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_61_70
{
    class Problem686
    {
        /*
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
                if (num.ToString().Length >= L.ToString().Length && int.Parse(num.ToString().Substring(0, L.ToString().Length)) == L)
                    count++;
                num *= 2;
                if (num.ToString().Length > L.ToString().Length + 11)
                    num /= (long)Math.Pow(10, L.ToString().Length + 2);
            }
            return power;
        } */
    }
}
