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
            findDistinctPowers(100);
        }
        static void findDistinctPowers(int power)
        {
            List<BigInteger> distinct = new List<BigInteger>();
            for (int i = 2; i<= power; i++)
            {
                for (int j = 2; j<= power; j++)
                {
                    var pow = new BigInteger(Math.Pow(i, j));
                    if (distinct.Contains(pow) == false)
                        distinct.Add(pow);
                }
            }
            for (int c = 0; c< distinct.Count; c++)
            {
                Console.WriteLine(distinct[c]);
            }
            Console.WriteLine(distinct.Count);
        }
    }
}


    


