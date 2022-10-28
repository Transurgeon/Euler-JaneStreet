using System;
using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;


namespace ProjectEuler.Net.Problems_61_70
{
    class Problem54
    {
        /*
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            //this is for reading txt files
            string path = @"C:\Users\Admin\source\repos\ProjectEuler.Net\Problems 61-70\p054_poker.txt";

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            String input = "";
            foreach (String line in lines)
            {
                input += line + "\n";
            }
            //comment out till here if no need :)
            watch.Start();
            Console.WriteLine(findAllHandValues(input));
            //List<int> test = new List<int>();
            //test.Add(1); test.Add(2);  test.Add(2); test.Add(14);test.Add(14);
            //List<List<int>> values = getOccurenceAndValues(test);
            //for (int i = 0; i < values.Count; i++)
            //{
            //    Console.WriteLine(values[i][0] + "," + values[i][1]);
            //}
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
        static int findAllHandValues(String input)
        {
            int count = 0;
            using (StringReader reader = new StringReader(input))
            {
                string hand = string.Empty;
                do
                {
                    hand = reader.ReadLine();
                    if (hand != null)
                    {
                        List<int> hand1 = getHandValue(hand.Substring(0, 15));
                        List<int> hand2 = getHandValue(hand.Substring(15));
                        int index = 0;
                        do
                        {
                            if (hand1[index] > hand2[index])
                                count++;
                            index++;
                        } while (hand1[index - 1] == hand2[index - 1]);
                    }

                } while (hand != null);
            }
            return count;
        }
        static List<int> getHandValue(String hand)
        {
            List<int> value = new List<int>();
            List<int> nums = getNums(hand);
            if (isFlush(hand))
            {
                if (!nums.Select((i, j) => i - j).Distinct().Skip(1).Any()) //isStraight
                {
                    if (hand.Contains('A') && hand.Contains('T'))
                    {
                        value.Add(9);
                    }
                    else
                    {
                        value.Add(8);
                        value.Add(nums[nums.Count - 1]);
                    }
                }
                else
                {
                    value.Add(5);
                    nums.Reverse();
                    value.AddRange(nums);
                }
            }
            else
            {
                if (!nums.Select((i, j) => i - j).Distinct().Skip(1).Any()) //isStraight
                {
                    value.Add(4);
                    value.Add(nums[nums.Count - 1]);
                }
                else
                {
                    List<List<int>> values = getOccurenceAndValues(nums);
                    if (values[0][0] == 1)
                    {
                        value.Add(0);
                    }
                    else if (values[0][0] == 2)
                    {
                        //check if double pair ... return 1 or 2
                        if (values[1][0] == 2)
                        {
                            value.Add(2);
                        }
                        else
                        {
                            value.Add(1);
                        }
                    }
                    else if (values[0][0] == 3)
                    {
                        //check if full-house ... return 3 or 6
                        if (values[1][0] == 2)
                        {
                            value.Add(6);
                        }
                        else
                        {
                            value.Add(3);
                        }
                    }
                    else if (values[0][0] == 4)
                    {
                        value.Add(7);
                    }
                    for (int i = 0; i < values.Count; i++)
                    {
                        value.Add(values[i][1]);
                    }
                }
            }
            return value;
        }
        static bool isFlush(String input)
        {
            string suits = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'C' || input[i] == 'H' || input[i] == 'D' || input[i] == 'S')
                    suits += input[i];
            }
            suits = suits.Replace(suits[0], ' ').Trim();
            if (suits == "")
                return true;
            return false;
        }
        static List<int> getNums(String input)
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                    nums.Add(int.Parse(input[i] + ""));
                else
                {
                    switch (input[i])
                    {
                        case 'T':
                            nums.Add(10);
                            break;
                        case 'J':
                            nums.Add(11);
                            break;
                        case 'Q':
                            nums.Add(12);
                            break;
                        case 'K':
                            nums.Add(13);
                            break;
                        case 'A':
                            nums.Add(14);
                            break;
                        default:
                            break;
                    }
                }
            }
            nums.Sort();
            return nums;
        }
        static List<List<int>> getOccurenceAndValues(List<int> nums)
        {
            List<List<int>> multiarray = new List<List<int>>();
            int i = 0;
            while (i < nums.Count)
            {
                List<int> row1 = new List<int>();
                row1.Add((from temp in nums where temp.Equals(nums[i]) select temp).Count());
                row1.Add(nums[i]);
                multiarray.Add(row1);
                i += (from temp in nums where temp.Equals(nums[i]) select temp).Count();
            }
            List<List<int>> values = multiarray.OrderBy(x => x[1]).OrderBy(y => y[0]).ToList();
            values.Reverse();
            return values;
        }*/

    } 
}
