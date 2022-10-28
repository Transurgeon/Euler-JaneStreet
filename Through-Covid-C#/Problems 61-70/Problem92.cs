using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_51_60
{
    class Problem92
    {
        /*        static void Main(string[] args)
        {
            Console.WriteLine(findSquareDigitChains(10000000));
        }

        static int findSquareDigitChains(int high)
        {
            int count = 0;
            for (int i = 1; i<=high;i++)
            {
                int num = i;
                while (true)
                {
                    num = getSquareDigit(num);
                    if (num == 89 || num == 1)
                        break;
                }
                if (num == 89)
                    count++;
            }
            return count;
        }
        static int getSquareDigit(int num)
        {
            int squareSum = 0;
            while (num!=0)
            {
                squareSum += (int)Math.Pow(num%10,2);
                num = num / 10; 
            }
            return squareSum;
        }*/
    }
}
