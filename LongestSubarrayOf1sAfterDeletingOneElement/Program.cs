﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubarrayOf1sAfterDeletingOneElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 1, 0, 1, 0, 1, 0 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 1, 1, 0, 1 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 1, 1, 1 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 0, 1, 1, 1, 0, 1, 1 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 0, 0, 1, 1 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 1, 0, 0, 0, 0 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 1, 1, 0, 0, 1, 1, 1, 0, 1 }));
        }

        public static int LongestSubarrayOf1sAfterDeletingOneElement(int[] nums)
        {
            if (!nums.Any(x => x == 0))
                return nums.Length - 1;

            int max = 0;
            bool isRemoved = false;
            int counter = 0;
            int lastCounter = 0;
            int firstCounter = 0;
            var index = 0;

            var listed = new List<int>(nums);

            for (int i = 0; i < listed.Count(); i++)
            {
                if (listed[i] == 1)
                {
                    while (listed[i] == 1)
                    {
                        counter++;
                        if (i < listed.Count() - 1)
                            i++;
                        else
                            break;
                    }
                    if (isRemoved)
                    {
                        lastCounter = counter - firstCounter;
                        isRemoved = false;
                        max = Math.Max(max, counter);
                        counter = lastCounter;
                    }
                    if (i == listed.Count() - 1)
                        break;

                    if (listed[i] == 0 && listed[i + 1] == 1)
                    {
                        firstCounter = counter;
                        isRemoved = true;
                        index = listed.IndexOf(listed[i]);
                    }
                    else if (listed[i] == 0 && listed[i + 1] == 0)
                    {
                        max = Math.Max(max, counter);
                        counter = 0;
                    }
                }
            }
            max = Math.Max(max, counter);

            return max;
        }
    }
}
