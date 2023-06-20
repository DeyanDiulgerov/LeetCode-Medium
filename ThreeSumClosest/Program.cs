using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSumClosest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 1));
            Console.WriteLine(ThreeSumClosest(new int[] { 0, 0, 0 }, 1));
        }

        public static int ThreeSumClosest(int[] nums, int target)
        {
            int len = nums.Length;
            int diff = int.MaxValue;
            Array.Sort(nums);
            for (int i = 0; i < len - 2; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (Math.Abs(sum - target) < Math.Abs(diff))
                        diff = sum - target;
                    if (sum < target)
                        j++;
                    else
                        k--;
                }
                if (diff == 0)
                    break;
            }
            return target + diff;
        }
    }
}
