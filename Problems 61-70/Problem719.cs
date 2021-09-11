using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_61_70
{
    class Problem719
    {
        /*         static void Main(string[] args)
        {
            Console.WriteLine(findNumberSplitting(4));
            //Console.WriteLine(isNumberSplittable(99));
        }
        static long findNumberSplitting(int power)
        {
            long sum = 0;
            for (long i = 4; i<= Math.Pow(10,power); i++)
            {
                if (isNumberSplittable(i))
                {
                    Console.WriteLine(i + "," + i*i);
                    sum += i * i;
                }
            }
            return sum;
        }
        static bool isNumberSplittable(long root)
        {
            return isNumberSplittable(root, (root * root).ToString(), 0);
        }

        static bool isNumberSplittable(long root, string num, long runningSum)
        {
            int i = 1;
            while (i<= num.ToString().Length && i<= num.Length)
            {
                if(isNumberSplittable(root,num.Substring(i),long.Parse(num.Substring(0,i))+runningSum))
                    return true;
                i++;
            }
            if (num.Length == 0 && root == runningSum)
                return true;
            return false;
        }*/
    }
}
