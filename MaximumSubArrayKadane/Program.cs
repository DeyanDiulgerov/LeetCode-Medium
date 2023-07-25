using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSubArrayKadane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumSubArrayKadane(new int[] { -1, -1, -2, -2 }));
            Console.WriteLine(MaximumSubArrayKadane(new int[] { 1, 2, -1 }));
            Console.WriteLine(MaximumSubArrayKadane(new int[] { -1, 0, -2 }));
            Console.WriteLine(MaximumSubArrayKadane(new int[] { -2, -1 }));
            Console.WriteLine(MaximumSubArrayKadane(new int[] { -1, -2 }));
            Console.WriteLine(MaximumSubArrayKadane(new int[] { -1 }));
            Console.WriteLine(MaximumSubArrayKadane(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
            Console.WriteLine(MaximumSubArrayKadane(new int[] { 1 }));
            Console.WriteLine(MaximumSubArrayKadane(new int[] { 5, 4, -1, 7, 8 }));
        }

        public static int MaximumSubArrayKadane(int[] nums)
        {
            int maxSum = nums[0];
            int currSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currSum = Math.Max(nums[i], currSum + nums[i]);

                maxSum = Math.Max(maxSum, currSum);
            }
            return maxSum;
        }
    }
}
