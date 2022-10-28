using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems
{
    class Problem14
    {
        /*
        static void Main(string[] args)
        {
            
            findLongestCollatzChain(1000000);
        }
        static void findLongestCollatzChain(int high)
        {
            int largestIndex = 1;
            long largestSeq = 0;
            long seq;
           for (int i = 2; i<high; i++)
            {
              seq = getSequenceCount(i);
                if (seq > largestSeq)
                {
                    largestSeq = seq;
                    largestIndex = i;
                }
            }
            Console.WriteLine(largestIndex);
        }
        static long getSequenceCount(long high)
        {
            long count = 0;
            while (true)
            {
                if (high == 1) 
                    return count;    
                else if (high % 2 == 0)
                    high = high / 2;
                else
                    high = 3 * high + 1;
                count++;
            } 
          
        }
   */
    }
}
