using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems_61_70
{
    class Problem69
    {

        /*solved using pen and paper
         using math theory, one can easily find that to achieve the greatest ratio between the numerator and the denominator
         we will need either 1. a very big numerator or 2. a comparatively very small denominator or 3. both 1,2 simultaneously
         
        ----------- 
        we can see that to achieve the lowest possible denominator for n, n should have the least amount of relative prime numbers
        in other words we want a number that is a factor of primes. since this would accrue only prime numbers in the denominator. 

        here is example of a function to find the highest n/phi(n) under a number: 'max

        static long getRatio (long max) 
        {
        long value = 1;
        do {
        value *= the next prime number; ie: 2*3*5*7*11*13*17 = 510510, since multiplying by 19 would net us a value over 10^6
        }(value < max)
        return value/lastPrime;
        }
        It is quite interesting to note that the highest n/phi(n) is the highest composite of unique primes
        while the lowest n/phi(n) is simply the highest prime, being relative prime to every non-prime number

        this is fun code to test for the convergence of the multiples of all primes p/p-1

        static void getPrimes()
        {
            double ratio = 3.0;
            List<long> primes = new List<long>();
            primes.Add(3); long num = 5;
            while (true)
            {                
                bool isPrime = true;
                for (int i = 0; i <primes.Count; i++)
                {
                    if (num % primes[i] == 0)
                    { 
                        isPrime = false;
                    }
                }
                if (isPrime == true)
                {
                    ratio *= num;
                    ratio /= (num - 1);
                    Console.WriteLine(ratio);
                    primes.Add(num);
                    Console.WriteLine(primes[primes.Count-1]);
                }
                num += 2;
            }
        }
         */


    }
}
