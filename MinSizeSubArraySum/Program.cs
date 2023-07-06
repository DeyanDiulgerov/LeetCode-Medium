using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinSizeSubArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinSizeSubArraySum(213, new int[] { 12, 28, 83, 4, 25, 26, 25, 2, 25, 25, 25, 12 }));
            Console.WriteLine(MinSizeSubArraySum(15, new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(MinSizeSubArraySum(7, new int[] { 2, 3, 1, 2, 4, 3 }));
            Console.WriteLine(MinSizeSubArraySum(4, new int[] { 1, 4, 4 }));
            Console.WriteLine(MinSizeSubArraySum(11, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }));
        }

        public static int MinSizeSubArraySum(int target, int[] nums)
        {
            int l = 0;
            int result = int.MaxValue;
            int sum = 0;

            for (int r = 0; r < nums.Length; r++)
            {
                sum += nums[r];

                while (sum >= target)
                {
                    result = Math.Min(result, r - l + 1);
                    sum -= nums[l];
                    l++;
                }
            }

            return result != int.MaxValue ? result : 0;
        }
    }
}
