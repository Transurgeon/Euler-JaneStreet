using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_21_30
{
    class Problem21
    {
        /*  static void Main(string[] args)
        {
            getAmicableNumbers(10000);
            Console.WriteLine(findDivisorSum(220));
            Console.WriteLine(findDivisorSum(284));
        }
        static void getAmicableNumbers(int high)
        {
            long sum = 0;
            for (int i = 1; i < high; i++)
            {
                for (int j = i+1; j < high; j++)
                {
                    if (findDivisorSum(i) == j && findDivisorSum(j) == i)
                    {
                        sum += i;
                        sum += j;
                    }
                }
            }
            Console.WriteLine(sum);
        }
        static int findDivisorSum(int num)
        {
            int sum = 1;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    sum += num / i;
                }
            }
            return sum;
        }*/
    }
}
