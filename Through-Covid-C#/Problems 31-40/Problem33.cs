using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_31_40
{
    class Problem33
    {
        /*         static void Main(string[] args)
        {
            findPandigitalProducts();
        }
        static void findPandigitalProducts()
        {
            double product = 1;
            for (int i = 11; i<100; i++)
            {
                if (i % 10 != 0)
                {
                    for (int j = i + 1; j < 100; j++)
                    {
                        if (j % 10 != 0)
                        {
                            if (isSpecialFraction(i, j))
                                Console.WriteLine(i + "/" + j);
                        }
                    }
                }
            }
        }
        static bool isSpecialFraction(int a, int b)
        {
            if (((a % 10 == b % 10) && isEquals(((double)a) / b, ((double)(a / 10)) / (b / 10)))
            ||  ((a % 10 == b / 10) && isEquals(((double)a) / b, ((double)(a / 10)) / (b % 10)))
            ||  ((a / 10 == b % 10) && isEquals(((double)a) / b, ((double)(a % 10)) / (b / 10)))
            ||  ((a / 10 == b / 10) && isEquals(((double)a) / b, ((double)(a % 10)) / (b % 10)))
            )
                return true;

            return false;
        }

        static bool isEquals(double first, double second)
        {
            return Math.Abs(first - second) < Math.Pow(10, -4);
        }*/
    }
}
