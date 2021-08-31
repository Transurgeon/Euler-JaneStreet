using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_21_30
{
    class Problem24
    {
        /*
         * static void Main(string[] args)
        {
             Console.WriteLine(findNthPermutation(9,999999));
            //Console.WriteLine(isPermutation(1235476890));
        }
        static string findNthPermutation(int lastDigit, int n)
        {
            
            if ((lastDigit < 0 && lastDigit > 9) || (n < 1 && n > getFactorial(lastDigit + 1)))
                return "!";
            string digits = "";
            for (int i = 0; i<=lastDigit; i++)
            {
                digits += i;
            }
            int index;
            string nthPerm = "";
            string result = "";
            for (int i = lastDigit; i>=0; i--)
            {
                index = n / getFactorial(i);
                n = n - (index*getFactorial(i));
                Console.WriteLine(index);
                nthPerm = digits.Substring(index, 1);
                result += digits.Substring(index, 1);
                digits = digits.Replace(nthPerm.ToString(),"");
                Console.WriteLine(digits);
            }
            return result;
        }
      /*  static bool isPermutation(long num)
        {
            String str;
            if (num < 1000000000)
                str = "0" + num;
            else
                str = ""+num;

            for (int i = 9; i>=0; i--)
            {
                str = str.Replace(i.ToString(),"");
                if (str.Length != i)
                    return false;
            }
            return true;
        } 

        static int getFactorial(int n)
        {
            int product = 1;
            for (int i = 2; i <= n; i++)
            {
                product *= i;
            }
            return product;
        }
        */
    }
}
