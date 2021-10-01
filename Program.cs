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
            Console.WriteLine(findInverseDigitSum(90));
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
        static long findInverseDigitSum(int max)
        {
            long[] fib = new long[max+1];
            long[] runningSum = new long[max + 1];
            fib[0] = 0; fib[1] = 1;
            runningSum[0] = 0; runningSum[1] = 1;
            for (int i = 2; i<=max; i++)
            {
                fib[i] = (fib[i - 1] + fib[i - 2]);
                runningSum[i] = findSeriesDigitSum(fib[i]) % 1000000007;
                while (runningSum[i] < 0)
                {
                    runningSum[i] += 1000000007; 
                }
                Console.WriteLine(runningSum[i] + "," + fib[i] + "," + i);
            }
            long sum = 0;
            for (int i = 0; i<runningSum.Length;i++)
            {
                sum += runningSum[i];
                sum = sum % 1000000007;
            }
            return sum % 1000000007;
        }
        //static long findLowestDigitSum()
        //{
        //    string num = currentDigit; long mod = 0;
        //    if (num.Length < 90)
        //    {
        //        mod = long.Parse(BigInteger.Parse(num) % 1000000007 + "");
        //    }
        //    else
        //    {
        //        string sub = num.Substring(0, 90);
        //        mod = long.Parse(BigInteger.Parse(sub) % 1000000007 + "");
        //        num = mod + "" + num.Substring(startIndex: 90);
        //        for (int i = 1; i<num.Length/90; i++)
        //        {
        //            sub = mod +"" + num.Substring(0, 90);
        //            mod = long.Parse(BigInteger.Parse(sub) % 1000000007 + "");
        //            num = mod + "" + num.Substring(startIndex: 90);
        //        }
        //        mod = long.Parse(BigInteger.Parse(num) % 1000000007 + "");
        //    }
        //    return mod;
        //}
        //static void incrementDigitSum()
        //{
        //    int first = int.Parse(currentDigit.Substring(0,1) + "");
        //    if (currentDigit.StartsWith('9'))
        //        currentDigit = '1' + currentDigit;
        //    else
        //    {
        //        currentDigit = (first + 1) + "" + currentDigit.Substring(1);
        //    }
        //}
        //public static long currentDigit = 1;
        //static long findLowestDigitSum(long num,long mod)
        //{
        //    return ((num % 9+1) * mod) - 1;
        //}

        //public static long power = 0;
        //public static long mod = 1;
        //static long findSeriesDigitSum(long start, long sum, long iterations)
        //{
        //    long i = start;
        //    for (long p = 0; p<iterations; p++)
        //    {
        //         if (i / 9 > power)
        //         {
        //            power++;
        //            mod = (mod*10) % 1000000007;
        //         }
        //         sum += ((i % 9 + 1) * mod) - 1;
        //        sum = sum % 1000000007;
        //        i++;
        //    }
        //    return sum;
        //}   
        static long findSeriesDigitSum(long fib)
        {
            long n = fib / 9;
            long r = 2 + (fib % 9);
            long x = ((r - 1) * r) % 1000000007;
            long y = (9 * n) % 1000000007;
            long first = ((x + 10) * emod(10,n% 1000000006, 1000000007)) % 1000000007;
            long second = (2 * (y+ r + 4)) % 1000000007;
            return ((first-second) % 1000000007 / 2) % 1000000007;
        }
        static long emod(long a, long b, long c)
        {
            if (b == 0)
                return 1;
            else if (b % 2 == 0)
            {
                long d = emod(a, b / 2, c);
                return (d * d) % c;
            }
            else
                return ((a % c * emod(a, b - 1, c)) % c);
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