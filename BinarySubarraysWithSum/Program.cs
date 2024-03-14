using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySubarraysWithSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySubarraysWithSum(new int[] { 1, 0, 1, 0, 1 }, 2));
            Console.WriteLine(BinarySubarraysWithSum(new int[] { 0, 0, 0, 0, 0 }, 0));
        }
        public static int BinarySubarraysWithSum(int[] nums, int goal)
        {
            int permLeft = 0, permRight = nums.Length - 1;
            int left = 0, right = 0;
            int res = 0;
            while (permLeft <= permRight)
            {
                int sum = 0;
                while (right <= permRight)
                {
                    sum += nums[right];
                    if (sum == goal)
                        res++;
                    right++;
                }
                while (left < right)
                {
                    sum -= nums[left];
                    left++;
                    if (left == right)
                        break;
                    if (sum == goal)
                        res++;
                }
                permLeft++;
                permRight--;
                left = permLeft;
                right = permLeft;
            }
            return res;
        }
    }
}
