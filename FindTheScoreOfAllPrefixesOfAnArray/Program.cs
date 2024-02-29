using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheScoreOfAllPrefixesOfAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindTheScoreOfAllPrefixesOfAnArray(new int[] { 2, 3, 7, 5, 10 })));
            Console.WriteLine(String.Join(",", FindTheScoreOfAllPrefixesOfAnArray(new int[] { 1, 1, 2, 4, 8, 16 })));
        }
        public static long[] FindTheScoreOfAllPrefixesOfAnArray(int[] nums)
        {
            int n = nums.Length;
            long prefix = 0, max = 0;
            long[] result = new long[n];
            for (int i = 0; i < n; i++)
            {
                max = Math.Max(max, nums[i]);
                prefix += nums[i] + max;
                result[i] = prefix;
            }
            return result;
        }
    }
}
