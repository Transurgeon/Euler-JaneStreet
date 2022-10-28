using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems
{
    class Problem15
    {

        /* 20 * 20 == 137846528820
       
        static void Main(string[] args)
        {
            
            Console.WriteLine(findRoutes(20));
        } 
        static long findRoutes(int size)
        {
            long [,] grid = new long[size+1, size+1];
            for (int i = size; i >= 0; i--)
            {
                for (int f = size; f >= 0; f--)
                {
                    if (i == size  || f == size )
                        grid[i, f] = 1;
                    else
                        grid[i, f] = grid[i + 1, f]+ grid[i, f+1];
                }
            }
            return grid[0, 0];
        }

         */
    }
}
