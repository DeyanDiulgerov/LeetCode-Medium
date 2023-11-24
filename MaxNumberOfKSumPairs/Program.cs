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
            Console.WriteLine(MaxNumberOfKSumPairs(new int[] { 3, 1, 5, 1, 1, 1, 1, 1, 2, 2, 3, 2, 2 }, 1));
            Console.WriteLine(MaxNumberOfKSumPairs(new int[] { 1, 2, 3, 4 }, 5));
            Console.WriteLine(MaxNumberOfKSumPairs(new int[] { 3, 1, 3, 4, 3 }, 6));
        }
        public static int MaxNumberOfKSumPairs(int[] nums, int k)
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
    }
}
