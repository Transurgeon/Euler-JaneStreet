using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net
{
    class Problem12
    {
        /* {
        
        static void Main(string[] args)
        {
            findHighlyDivisible(500);
        }
        static void findHighlyDivisible(int high)
        {
            int divCount = 0;
            int a = 1;
            do
            {
                long sum = (a * (a+1))/ 2;
                Console.WriteLine(sum);
                divCount = findDivisorCount(sum);
                Console.WriteLine(divCount);
                if (divCount > high)
                {
                    Console.WriteLine(sum);
                    
                    break;
                }
                a++;
            } while (divCount < high);
               
        }

        static int findDivisorCount(long num)
        {
            int count = 0;

            for(int i=1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    count+=2;
            }
            return count;
        }

        */
    }
}
