using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems
{
    class Problem4
    {
        /*static void Main(string[] args)
        {

            FindLargestPalyndrome();
        }

        static void FindLargestPalyndrome()
        {
            int largest = 0;
            int product = 0;
            int first = 0;
            int second = 0;
           for (int i = 199; i<999; i++)
            {
                for (int f = i; f<999; f++)
                {
                    product = f * i;
                    if (isPalyndrome(product)==true){
                        if(product > largest)
                        {
                            largest = product;
                            first = i;
                            second = f;
                        }
                    }
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(largest);
        }
        static Boolean isPalyndrome(int a)
        {
            String reverse = "";
            String num = a.ToString();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                reverse += num[i];
            }
            if (reverse.Equals(num))
                return true;
            return false;
        }*/
    }
}
