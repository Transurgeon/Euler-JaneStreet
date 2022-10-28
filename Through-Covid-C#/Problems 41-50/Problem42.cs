using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_41_50
{
    class Problem42
    {
        /*    static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\source\repos\ProjectEuler.Net\Problems 41-50\p042_words.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            String input = "";
            foreach (String line in lines)
            {
                input += line + " ";
            }
            findTriangleWords(input);
        }
        static void findTriangleWords(String input)
        {
            int count = 0;
            String[] words = (input.Replace('"', ' ')).Split(',');

            for (int i = 0; i < words.Length; i++)
            {

                if ((((-1 + Math.Sqrt(1 + 8 * getScoreOfWord(words[i]))) / 2) - Math.Floor(((-1 + Math.Sqrt(1 + 8 * getScoreOfWord(words[i]))) / 2))) < 0.0001)
                {
                    count++;
                    Console.WriteLine(words[i] + ", " + count);
                }

            }
            Console.WriteLine(count);
        }
        static int getScoreOfWord(String input)
        {
            int sum = 0;
            foreach (char s in input)
            {
                sum += (int)s % 32;
            }
            return sum;
        }*/
    }
}
