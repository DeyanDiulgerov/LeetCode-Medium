using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberOfKSumPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxNumberOfKSumPairsDiff(new int[] { 3, 1, 5, 1, 1, 1, 1, 1, 2, 2, 3, 2, 2 }, 1));
            Console.WriteLine(MaxNumberOfKSumPairsDiff(new int[] { 1, 2, 3, 4 }, 5));
            Console.WriteLine(MaxNumberOfKSumPairsDiff(new int[] { 3, 1, 3, 4, 3 }, 6));

            Console.WriteLine(MaxNumberOfKSumPairsTwoPointer(new int[] { 3, 1, 5, 1, 1, 1, 1, 1, 2, 2, 3, 2, 2 }, 1));
            Console.WriteLine(MaxNumberOfKSumPairsTwoPointer(new int[] { 1, 2, 3, 4 }, 5));
            Console.WriteLine(MaxNumberOfKSumPairsTwoPointer(new int[] { 3, 1, 3, 4, 3 }, 6));
        }
        // seenNums List And diff == k - nums[i] approach
        public static int MaxNumberOfKSumPairsDiff(int[] nums, int k)
        {
            var usedNums = new List<int>();
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = k - nums[i];
                if (usedNums.Contains(diff))
                {
                    usedNums.Remove(diff);
                    counter++;
                }
                else
                    usedNums.Add(nums[i]);
            }
            return counter;
        }
        // Two Pointer Approach
        public static int MaxOperationsTwoPointer(int[] nums, int k)
        {
            Array.Sort(nums);
            int result = 0;
            int left = 0, right = nums.Length - 1;
            while(left < right)
            {
                if(nums[left] + nums[right] == k)
                {
                    left++;
                    right--;
                    result++;
                }
                else if(nums[left] + nums[right] > k)
                    right--;
                else//if(nums[left] + nums[right] < k)
                    left++;
            }
            return result;
        }
    }
}
