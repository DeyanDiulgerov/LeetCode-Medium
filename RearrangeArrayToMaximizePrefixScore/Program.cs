using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RearrangeArrayToMaximizePrefixScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RearrangeArrayToMaximizePrefixScore(new int[] { 2, -1, 0, 1, -3, 3, -3 }));
            Console.WriteLine(RearrangeArrayToMaximizePrefixScore(new int[] { -2, -3, 0 }));
        }
        public static int RearrangeArrayToMaximizePrefixScore(int[] nums)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            int n = nums.Length;
            long prefix = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                prefix += nums[i];
                if (prefix > 0)
                    count++;
                else
                    break;
            }
            return count;
        }
    }
}
