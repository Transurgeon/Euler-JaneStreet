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
           findNonAbundant();
        }
        static void findNonAbundant()
        {
            List<int> abundants = new List<int>();
            for (int i = 1; i <= 28122; i++)
            {
                if (findDivisorSum(i) > i)
                {
                    abundants.Add(i);
                }
            }
            int num = 1;
            long sum = 0;
            while (num < 28123)
            {
                if (isSumOfAbundant(abundants, num)) { 
                sum += num;
                Console.WriteLine(num);
                Console.WriteLine(sum);
            }
                num++;
            }
        }
         static bool isSumOfAbundant(List <int> numbers, int num)
        {
            int Limit = 0;
            for (int k = 0; k<numbers.Count; k++)
            {
                if (numbers[k] > num)
                {
                    Limit = k;
                    break;
                }

            }
            for (int i = 0; i< Limit; i++)
            {
                for (int j = i; j < Limit; j++)
                {
                    if (num == numbers[i] + numbers[j])
                        return false;
                }
            }

            return true;
        }
        static int findDivisorSum(int num)
        {
            int sum = 1;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    if (i == Math.Sqrt(num))
                        sum += i;
                    else
                    {
                        sum += i;
                        sum += num / i;
                    }
                }
            }
            return sum;
        }
       
    }

}

    


