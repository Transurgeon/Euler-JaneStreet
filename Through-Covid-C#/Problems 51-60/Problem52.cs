using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Remaining_5
{
    class Problem52
    {
        /*         static void Main(string[] args)
        {
           Console.WriteLine(findPermutedMultiples());
        }

        static long findPermutedMultiples()
        {
            long i = 10;
           while (true)
            {
                if (arePermutations(i, 2 * i, 3 * i, 4 * i, 5 * i, 6 * i))
                    return i;
                if (i.ToString().Substring(0, 2).Equals("17"))
                    i = (int)Math.Pow(10, i.ToString().Length + 1);
                else
                    i++;
            }
        }

        static bool arePermutations(long a, long b, long c, long d, long e, long f)
        {
            if (a.ToString().Length != f.ToString().Length)
                return false;
            string num1 = ""+a,num2 = ""+b, num3 = ""+c, num4 = ""+d, num5 = ""+e, num6 = ""+f;
            for (int i = 0; i<=9;i++)
            {
                num1= num1.Replace(i.ToString(), "");
                num2= num2.Replace(i.ToString(), "");
                num3= num3.Replace(i.ToString(), "");
                num4 = num4.Replace(i.ToString(), "");
                num5 = num5.Replace(i.ToString(), "");
                num6 = num6.Replace(i.ToString(), "");
                if (num1.Length != num2.Length || num2.Length != num3.Length ||num3.Length != num4.Length || num4.Length != num5.Length || num5.Length != num6.Length)
                    return false;
            }
            return true;
        }*/
    }
}
