using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxConsecutiveOnesIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", MaxConsecutiveOnesIII(
                new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2)));
            Console.WriteLine(String.Join(",", MaxConsecutiveOnesIII(
                new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3)));
        }

        public static int MaxConsecutiveOnesIII(int[] nums, int k)
        {
            int left = 0;
            int max = 0;
            int countZeroes = 0; 

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                    countZeroes++;

                while (countZeroes > k)
                {
                    if (nums[left] == 0)
                        countZeroes--;

                    left++;
                }
                max = Math.Max(max, right - left + 1);
            }
            return max;
        }
    }
}
