using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestArithmeticSeqLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestArithmeticSeqLength(new int[] { 3, 6, 9, 12 }));
            Console.WriteLine(LongestArithmeticSeqLength(new int[] { 9, 4, 7, 2, 10 }));
            Console.WriteLine(LongestArithmeticSeqLength(new int[] { 20, 1, 15, 3, 10, 5, 8 }));
        }

        public static int LongestArithmeticSeqLength(int[] nums)
        {
            int maxCount = 2;
            int end = 0;

            var dictionary = new Dictionary<(int, int), int>();

            while (end < nums.Length)
            {
                int start = 0;

                while (start < end)
                {
                    int diff = nums[end] - nums[start];
                    int val = dictionary.ContainsKey((start, diff)) ? dictionary[(start, diff)] : 2;
                    dictionary[(end, diff)] = val + 1;

                    maxCount = Math.Max(maxCount, val);

                    start++;
                }

                end++;
            }

            return maxCount;
        }
    }
}
