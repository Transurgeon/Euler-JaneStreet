using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_31_40
{
    class Problem36
    {
        /*         static void Main(string[] args)
        {
            findDoublePalyndrome(1000000);
        }
        static void findDoublePalyndrome(int limit)
        {
            int sum = 0;
            for (int i = 1; i<limit; i++)
            {
                if (isPalyndrome(i.ToString()) && isPalyndrome(getBinary(i)))
                {
                    Console.WriteLine(i + ", " + getBinary(i));
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
        static string getBinary(int n)
        {
            int high = (int)Math.Log2(n);
            string binary = "";
            do
            {
                if (n > (int)Math.Pow(2, high))
                {
                    n = n - (int)Math.Pow(2, high);
                    binary += 1;
                }
                else if (n == (int)Math.Pow(2, high))
                {
                    n = n - (int)Math.Pow(2, high);
                    binary += 1;
                    for (int i = high; i>0; i--)
                    {
                        binary += 0;
                    }
                }
                else
                    binary += 0;
                
                high--;
            } while (n != 0);
            return binary;
        }
        static bool isPalyndrome(string num)
        {
            string reverse = "";

            for (int i = num.Length-1; i>=0; i--)
            {
                reverse += num[i];
            }
            if (reverse == num)
                return true;
            return false;
        }*/
    }
}
