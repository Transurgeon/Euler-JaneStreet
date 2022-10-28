using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_41_50
{
    class Problem50
    {
        /*         static void Main(string[] args)
        {
           findPrimePermutation();
        }

        static void findPrimePermutation()
        {
            for (int i = 1001; i<9999; i+=2)
            {
                if (isPrime(i))
                {
                    for (int j = 2; j <=5000; j +=2)
                    {
                        int b = i + j;
                        int c = i + 2 * j;
                        if (isPrime(b) && isPrime(c) && arePermutations(i,b,c))
                        {
                            Console.WriteLine(i + ","+b+","+c);
                        }
                    }
                }
            }
        }

        static bool arePermutations(int a, int b, int c)
        {
            if (c>9999)
                return false;
            string num1 = ""+a,num2 = ""+b, num3 = ""+c;
            for (int i = 0; i<=9;i++)
            {
                num1= num1.Replace(i.ToString(), "");
                num2= num2.Replace(i.ToString(), "");
                num3= num3.Replace(i.ToString(), "");
                if (num1.Length != num2.Length || num2.Length != num3.Length)
                    return false;
            }
            return true;
        }
        static Boolean isPrime(long a)
        {
            if (a < 2)
                return false;
            if (a % 2 == 0 && a != 2)
                return false;
            for (int i = 3; i <= Math.Sqrt(a); i += 2)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }*/
    }
}
