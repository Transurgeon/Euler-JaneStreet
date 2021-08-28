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
            DateTime dt = new DateTime(1901, 1, 6);
            DateTime ed = new DateTime(2000, 12, 31);
            getNumberOfSundays(dt,ed);
            
        }
        static void getNumberOfSundays(DateTime start, DateTime end)
        {
            //int dayOfWeek = 2;
            int count = 0;
            while (start.Year <= end.Year)
            {
               // if (dayOfWeek > 7)
                   // dayOfWeek = dayOfWeek % 7;
                if (start.Day == 1)
                    count++;
                //incrementation
                //dayOfWeek++;
                start = start.AddDays(7);
                Console.WriteLine(start);
            }

            Console.WriteLine(count);
        }
    }

}

    


