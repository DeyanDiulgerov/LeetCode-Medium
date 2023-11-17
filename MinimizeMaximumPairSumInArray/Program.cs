using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimizeMaximumPairSumInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimizeMaximumPairSumInArray(new int[] { 3, 5, 2, 3 }));
            Console.WriteLine(MinimizeMaximumPairSumInArray(new int[] { 3, 5, 4, 2, 4, 6 }));
        }

        public static int MinimizeMaximumPairSumInArray(int[] nums)
        {
            int n = nums.Length; // ALWAYS EVEN
            Array.Sort(nums);
            var allSums = new List<int>();
            int left = 0, right = nums.Length - 1;

            for (int i = 0; i < n / 2; i++)
            {
                var newSum = nums[left] + nums[right];
                left++;
                right--;
                allSums.Add(newSum);
            }
            return allSums.Max();
        }
    }
}
