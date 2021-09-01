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
            findPandigitalProducts();
        }
        static void findPandigitalProducts()
        {
            String str = "";
            List<int> products = new List<int>();
            int sum = 0;
            for (int i = 1; i<9876; i++)
            {
                for (int j = 1; j<100; j++)
                {
                    str = i+""+j+"" + (i * j);
                    if (isPandigital(str))
                    {
                        if (products.Contains(i * j) == false)
                        {
                            Console.WriteLine(str + "," + (i * j));
                            products.Add(i * j);
                            sum += (i * j);
                        }
                    }
                }
            }
            Console.WriteLine(sum);
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


    


