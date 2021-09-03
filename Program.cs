using System;
using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Net
{
    class Program
    {
        static void Main(string[] args)
        {
           findPandigitalMultiples();

        }
        static void findPandigitalMultiples()
        {
            int largest = 0;
            string str = ""; 
            for (int i = 1; i<9999; i++)
            {
                for (int j = 2; j <= 5; j++)
                {
                    str = "";
                    for (int k = 1; k<=j; k++)
                    {
                        str += "" + (i * k);
                    }
                    if (isPandigital(str))
                    {
                        Console.WriteLine(str+","+i+","+j);
                        if (int.Parse(str) > largest)
                            largest = int.Parse(str);
                    }
                }
            }
            Console.WriteLine(largest);
        }
        static bool isPandigital(String concat)
        {
            if (concat.Contains('0'))
                return false;
            int length = concat.Length;
            for (int i = 1; i <= 9; i++)
            {
                concat = concat.Replace(i.ToString(), "");
                length--;
                if (concat.Length != length)
                    return false;
            }
            return true;
        }

    }
}


    


