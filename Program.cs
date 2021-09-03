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
           findRightTriangle(1000);

        }
        static void findRightTriangle(int n)
        {
            int largest = 0;
            int largestPos = 0;
            int[] numSolutions = new int[n + 1];

            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (i + j + ((int)Math.Sqrt(i * i + j * j)) <= 1000)
                    {
                        if (Math.Sqrt(i * i + j * j) - Math.Floor(Math.Sqrt(i * i + j * j)) < 0.0001)
                            numSolutions[i + j + ((int)Math.Sqrt(i * i + j * j))]++;
                    }
                }

            }
            for (int k = 0; k< n; k++)
            {
                if (numSolutions[k] > largest)
                {
                    Console.WriteLine(largestPos + ", " + largest);
                    largest = numSolutions[k];
                    largestPos = k;
                }
            }
            Console.WriteLine(largestPos+", " + numSolutions[largestPos]);
        }

    }
}


    


