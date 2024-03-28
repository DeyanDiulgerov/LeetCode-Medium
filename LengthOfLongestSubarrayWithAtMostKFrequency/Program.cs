using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLongestSubarrayWithAtMostKFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubarrayWithAtMostKFrequency(new int[] { 1, 2, 3, 1, 2, 3, 1, 2 }, 2));
            Console.WriteLine(LengthOfLongestSubarrayWithAtMostKFrequency(new int[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 1));
            Console.WriteLine(LengthOfLongestSubarrayWithAtMostKFrequency(new int[] { 5, 5, 5, 5, 5, 5, 5 }, 4));
        }
        public static int LengthOfLongestSubarrayWithAtMostKFrequency(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            int left = 0, right = 0;
            int max = 0;
            while (right < nums.Length)
            {
                if (!map.ContainsKey(nums[right]))
                    map.Add(nums[right], 1);
                else
                    map[nums[right]]++;

                if (map[nums[right]] > k)
                {
                    max = Math.Max(max, right - left);
                    while (map[nums[right]] > k)
                    {
                        map[nums[left]]--;
                        left++;
                    }
                }
                right++;
            }
            max = Math.Max(max, nums.Length - left);
            return max;
        }
    }
}
