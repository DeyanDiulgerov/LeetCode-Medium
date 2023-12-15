using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubarrayWhereMaximumElementAppearsAtleastKTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSubarrayWhereMaximumElementAppearsAtleastKTimes(new int[] { 1, 0, 3, 8, 8, 8, 7, 8, 7 }, 2));
            Console.WriteLine(CountSubarrayWhereMaximumElementAppearsAtleastKTimes(new int[] { 1, 4, 4, 3, 4 }, 2));
            Console.WriteLine(CountSubarrayWhereMaximumElementAppearsAtleastKTimes(new int[]
            { 28, 5, 58, 91, 24, 91, 53, 9, 48, 85, 16,
                70, 91, 91, 47, 91, 61, 4, 54, 61, 49 }, 1));
            Console.WriteLine(CountSubarrayWhereMaximumElementAppearsAtleastKTimes(new int[]
            { 61, 23, 38, 23, 56, 40, 82, 56, 82, 82, 82, 70, 8,
                69, 8, 7, 19, 14, 58, 42, 82, 10, 82, 78, 15, 82 }, 2));
            Console.WriteLine(CountSubarrayWhereMaximumElementAppearsAtleastKTimes(new int[] { 1, 3, 2, 3, 3 }, 2));
            Console.WriteLine(CountSubarrayWhereMaximumElementAppearsAtleastKTimes(new int[] { 1, 4, 2, 1 }, 3));
        }
        public static long CountSubarrayWhereMaximumElementAppearsAtleastKTimes(int[] nums, int k)
        {
            int n = nums.Length;
            long max = nums.Max();
            long left = 0, right = 0;
            long counter = 0;
            long resultCount = 0;

            while (right < n)
            {
                if (nums[right] == max)
                    counter++;

                if (counter >= k)
                {
                    while (counter >= k)
                    {
                        resultCount += n - right;
                        if (nums[left] == max)
                            counter--;

                        left++;
                    }
                }
                right++;
            }
            return resultCount;
        }
    }
}
