using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems
{
    class Problem18
    {
        /* static void Main(string[] args)
        {
            // String input = "75 95 64 17 47 82 18 35 87 10 20 04 82 47 65 19 01 23 75 03 34 88 02 77 73 07 63 67 99 65 04 28 06 16 70 92 41 41 26 56 83 40 80 70 33 41 48 72 33 47 32 37 16 94 29 53 71 44 65 25 43 91 52 97 51 14 70 11 33 28 77 73 17 78 39 68 17 57 91 71 52 38 17 14 91 43 58 50 27 29 48 63 66 04 68 89 53 67 30 73 16 69 87 40 31 04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
            
            string path = @"C:\Users\Admin\source\repos\ProjectEuler.Net\Problems 11-20\triangle.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            String input = "";
            foreach (String line in lines)
            {
                input += line + " ";
            }
            getMaximumSumPath(input);
            
        }
        static void getMaximumSumPath(String input)
        {
            string[] numbers = input.Split(" ");
            //debug(createTriangle(numbers));
            Console.WriteLine(findLargestPath(createTriangle(numbers)));
        }
        static int[][] createTriangle(String[] input)
        {
            int size = (int)((-1 + Math.Sqrt(1+8*input.Length))/2);
            
            int inputCount = 0;
            int[][] grid = new int[size][];
            for (int i = 0; i < size; i++)
            {
                grid[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    grid[i][j] = int.Parse(input[inputCount]);
                    inputCount++;
                }
            }   
            return grid;
        }

        static void debug(int[][] input)
        {
            for (int i = 0; i<input.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(input[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int findLargestPath(int[][] input)
        {
       
            for (int i = 1; i<input.Length; i++)
            {
                for (int j = 0; j<=i; j++)
                {
                    if (j == 0)
                        input[i][j] += input[i - 1][j];
                    else if (j == i)
                        input[i][j] += input[i - 1][j - 1];
                    else
                    {
                        if (input[i - 1][j] > input[i - 1][j - 1])
                            input[i][j] += input[i - 1][j];
                        else 
                            input[i][j] += input[i - 1][j-1];
                    }
                }
            }


            int max = input[input.Length - 1][0];
            for (int j = 1; j<input.Length; j++)
            {
                if (input[input.Length - 1][j] > max)
                    max = input[input.Length - 1][j];
            }
            return max;
        } */

    }

}
