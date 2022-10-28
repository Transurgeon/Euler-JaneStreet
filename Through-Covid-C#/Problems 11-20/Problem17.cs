using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Net.Problems
{
    class Problem17
    {
		/* static void Main(string[] args)
        {
            getNumberCounter(1000);
        } 
        static void getNumberCounter(int max)
        {
            int sum = 0;
            for (int i= 1; i <=max; i++)
            {
                sum += getNumberCount(i);
            }
            Console.WriteLine(sum);
        }
		static int getNumberCount(int number)
		{
			int total = 0;

	        if (number > 99 && number % 100 > 0)

				total += 3;

			if ((number / 1000) % 10 > 0)

				total += getSingleDigit((number / 1000) % 10) + 8;

			if ((number / 100) % 10 > 0)

				total += getSingleDigit((number / 100) % 10) + 7;

			if ((number / 10) % 10 > 1)
			{
				switch ((number / 10) % 10)
				{
					case 4:
						total += 5;
						break;
					case 5:
						total += 5;
						break;
					case 6:
						total += 5;
						break;
					case 2:
						total += 6;
						break;
					case 3:
						total += 6;
						break;
					case 8:
						total += 6;
						break;
					case 9:
						total += 6;
						break;
					case 7:
						total += 7;
						break;
				}

				total += getSingleDigit(number % 10);
			}
			else if ((number / 10) % 10 == 1)
			{
				switch (number % 10)
				{
					case 0:
						total += 3;
						break;
					case 1:
						total += 6;
						break;
					case 2:
						total += 6;
						break;
					case 4:
						total += 8;
						break;
					case 5:
						total += 7;
						break;
					case 6:
						total += 7;
						break;
					case 3:
						total += 8;
						break;
					case 8:
						total += 8;
						break;
					case 9:
						total += 8;
						break;
					case 7:
						total += 9;
						break;
				}
			}
			else if ((number / 10) % 10 == 0)
			{
				total += getSingleDigit(number % 10);
			}
			return total;
		}

		static int getSingleDigit(int digit)
		{
			switch (digit)
			{
				case 1:
					return 3;
				case 2:
					return 3;
				case 6:
					return 3;
				case 4:
					return 4;
				case 5:
					return 4;
				case 9:
					return 4;
				case 3:
					return 5;
				case 7:
					return 5;
				case 8:
					return 5;
				case 0:
					return 0;
				default:
					break;
			}
			return 0;
		} */
	}
}
