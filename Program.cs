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
            // we multiply by 10 because any number squared that ends in 0 is a multiple of 10
            Console.WriteLine(getConcealedSquare()*10); 
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            foreach (long c in perm)
            {
                Console.WriteLine(c);
            }
        }
        static BigInteger getConcealedSquare()
        {
            var root = new BigInteger(138902663); //sqrt of max possible number (19293949596979899)
            while (true)
            {
                var square = new BigInteger((root * root).ToByteArray());
                Console.WriteLine(square);
                bool cond = true;
                for (int i = 0; i<9; i++)
                {
                    if (square.ToString().Substring(2 * i, 1) != (i + 1).ToString())
                        cond = false;
                }
                if (cond == true)
                    return root;
                root -= 2; // we skip all even numbers because to get 9 from squaring n : n can only be 3,7
            }
        }
        static bool findConcealedSquare(String concat2)
        {
            Console.WriteLine(concat2);
            string concat1 = "1234567890";
            string numero = "";
            for (int i = 0; i < Math.Max(concat1.Length,concat2.Length); i++)
            {
                if (i < concat1.Length)
                {
                    numero+=concat1[i];
                }
                if (i < concat2.Length)
                {
                    numero+=concat2[i];
                }
            }
            var num = BigInteger.Parse(numero);
            Console.WriteLine(numero);
            if (checkPerfectSquare(num, 1, num) != -1)
            {
                return true;
            }
            return false;
        }
        public static BigInteger checkPerfectSquare(BigInteger N,
                                             BigInteger start,
                                             BigInteger last)
        {
            BigInteger mid = (start + last) / 2;

            if (start > last)
            {
                return -1;
            }
            if (mid * mid == N)
            {
                return mid;
            }
            else if (mid * mid > N)
            {
                return checkPerfectSquare(N, start,
                                          mid - 1);
            }
            else
            {
                return checkPerfectSquare(N, mid + 1,
                                          last);
            }
        }

        static int[] digits = new int[] { 9,8,7,6,5,4,3,2,1,0};
        static List<long> perm = new List<long>();
        static void Rec(int current, int numDigits)
        {
            if (numDigits == 0)
            {
                if (findConcealedSquare(current.ToString().PadLeft(9, '0')))
                perm.Add(long.Parse(current.ToString()));
            }
            else
                foreach (int x in digits)
                    Rec(current * 10 + x, numDigits - 1);
        }

    }
}






