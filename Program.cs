using System;
using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace ProjectEuler.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            string path = @"C:\Users\Admin\source\repos\ProjectEuler.Net\Problems 51-60\p059_cipher.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            String input = "";
            foreach (String line in lines)
            {
                input += line + " ";
            }
            decrypt(input);
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
        static void decrypt(string input)
        {
            char[] pass = "god".ToCharArray();
            String[] ascii = input.Split(',');
            for (int i = 0; i < ascii.Length; i++)
            {
                ascii[i] = char.ToString((char)(int.Parse(ascii[i])^pass[i % 3]));
                Console.Write(ascii[i]);
            }
        }

        //static int[] digits = new int[] { 9,8,7,6,5,4,3,2,1,0};
        //static List<long> perm = new List<long>();
        //static void Rec(int current, int numDigits)
        //{
        //    if (numDigits == 0)
        //    {
        //        perm.Add(long.Parse(current.ToString()));
        //    }
        //    else
        //        foreach (int x in digits)
        //            Rec(current * 10 + x, numDigits - 1);
        //}

    }
}






