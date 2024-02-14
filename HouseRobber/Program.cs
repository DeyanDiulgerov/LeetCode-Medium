using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRobber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HouseRobber(new int[] { 1, 3, 1 }));
            Console.WriteLine(HouseRobber(new int[] { 1, 2 }));
            Console.WriteLine(HouseRobber(new int[] { 1, 2, 3, 1 }));
            Console.WriteLine(HouseRobber(new int[] { 2, 7, 9, 3, 1 }));
        }
        // My Way!!!
        public static int Rob(int[] nums)
        {
            int n = nums.Length;
            if (n == 1)
                return nums[0];
            for (int i = 2; i < n; i++)
            {
                if (i == 2)
                    nums[i] += nums[i - 2];
                else
                    nums[i] += Math.Max(nums[i - 2], nums[i - 3]);
            }
            return Math.Max(nums[n - 1], nums[n - 2]);
        }
        public static int HouseRobber2(int[] nums)
        {
            int pp = 0;
            int p = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int t = p;
                p = Math.Max(p, pp + nums[i]);
                pp = t;
            }
            return p;
        }
    }
}
