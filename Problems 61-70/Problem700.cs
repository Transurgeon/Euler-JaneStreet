using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_61_70
{
    class Problem700
    {
        /*        
         *        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            Console.WriteLine(findEulerCoinSum());
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
        static BigInteger findEulerCoinSum()
        {
            BigInteger sum = 1504170715041707;
            List<BigInteger> coins = new List<BigInteger>();
            coins.Add(1504170715041707);
            long n = 0;
            while (n < 4500099627370517)
            {
                var modular = new BigInteger(n * 1504170715041707 % 4503599627370517);
                if (modular < coins[coins.Count-1] && modular > 0)
                { 
                    Console.WriteLine(modular+","+n);
                    coins.Add(modular);
                    sum += modular;
                }
                n++;
            }
            return sum;
        }*/
    }
}
