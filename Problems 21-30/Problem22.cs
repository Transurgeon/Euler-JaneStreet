using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_21_30
{
    class Problem22
    {
        /* static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\source\repos\ProjectEuler.Net\Problems 21-30\p022_names.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            String input = "";
            foreach (String line in lines)
            {
                input += line + " ";
            }
            getScoreOfNames(input);
        }
        static void getScoreOfNames(String input)
        {
            long sum = 0;
            String[] names = (input.Replace('"', ' ')).Split(',');
            Array.Sort(names);

            for (int i = 0; i < names.Length; i++)
            {
                sum += getNameofScores(names[i]) * (i + 1);
            }
            Console.WriteLine(sum);
        }
        static int getNameofScores(String input)
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
