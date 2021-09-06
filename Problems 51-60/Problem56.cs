using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_51_60
{
    class Problem56
    {
        /*         static void Main(string[] args)
        {
            Console.WriteLine(findMaximalDigitSum());
        }
        static int findMaximalDigitSum()
        {
            int largest = 0;
            for (int i = 1; i<=100; i++)
            {
                for (int j = 1; j <= 100; j++)
                {
                    if (findDigitSum(i,j) > largest)
                    {
                        largest = findDigitSum(i,j);
                        Console.WriteLine(i + "," + j+","+largest);
                    }
                }
            }
            return largest;
        }
        static int findDigitSum(int num1, int num2)
        {
            var product = new BigInteger(1);
            for (int i = 1; i <= num2; i++)
            {
                product *= num1;
            }
            int digits = 0;
            while (product!=0)
            {
                digits += int.Parse((product % 10).ToString());
                product = product / 10;
            }
            return digits;
        }*/
    }
}
