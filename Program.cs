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
            findPowerfulCount();
        }
        static void findPowerfulCount()
        {
            int count = 0;
            for (int i = 0; i<25;i++)
            {
                int n = 1;
                while (true)
                {
                    if (Math.Pow(n, i + 1) >= Math.Pow(10, i + 1))
                        break;
                    else if (Math.Pow(n, i + 1) >= Math.Pow(10, i))
                    {
                        Console.WriteLine(Math.Pow(n, i + 1));
                        count++;
                    }
                    n++;
                }
            }
            Console.WriteLine(count);
        }
    }
}


    


