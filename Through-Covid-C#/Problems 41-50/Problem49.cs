using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_41_50
{
    class Problem49
    {
        /*        static void Main(string[] args)
        {
            Console.WriteLine(findHighestConsecutivePrimeSum(1000000));
        }

        static List<int> primes = new List<int>();

        static int findHighestConsecutivePrimeSum(int high)
        {
            int largest = 0;
            int largestP = 0;
            for (int i = 2; i<= high; i++)
            {
                if (isPrime(i))
                {
                    primes.Add(i);
                    if (findConsecutivePrime(i, largest) > largest)
                    {
                        largest = findConsecutivePrime(i, largest);
                        largestP = i;
                        Console.WriteLine(largestP + ", " + largest);
                    }
                }
            }
            return largestP;
        }

        static int findConsecutivePrime(int prime, int largest)
        {
            int pos = primes.IndexOf(prime) - largest;
            int n = 0;
            int sum = 0;
            while (n < pos)
            {
                for (int i = n; i<=pos; i++)
                {
                    sum += primes[i];
                    if (sum > prime)
                    {
                        break;
                    }
                    else if (sum == prime)
                        return i - n+1;
                }
                sum = 0;
                n++;
            }
            return 0;
        }
        static Boolean isPrime(long a)
        {
            if (a < 2)
                return false;
            if (a % 2 == 0 && a != 2)
                return false;
            for (int i = 3; i <= Math.Sqrt(a); i += 2)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        } */
    }
}
