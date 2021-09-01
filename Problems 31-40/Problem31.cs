using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_31_40
{
    class Problem31
    {
        /*         static void Main(string[] args)
        {
            
            
            int[] coins= { 1, 2, 5, 10, 20, 50, 100, 200};
            findCoinSums(200, coins);
        }
        static void findCoinSums(int target, int[] coins)
        {
            int[] ways = new int[target + 1];
            ways[0] = 1;
            for (int i = 0; i<coins.Length; i++)
            {
                for (int j = 0; j < ways.Length; j++)
                {
                    if (coins[i] <= j)
                        ways[j] += ways[j - coins[i]];
                }
            }
            Console.WriteLine( ways[target]);
        }
          */
    }
}
