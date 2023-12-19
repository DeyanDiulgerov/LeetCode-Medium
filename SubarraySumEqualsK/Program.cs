using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubarraySumEqualsK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubarraySumEqualsK(new int[] { -1, -1, 1 }, 0));
            Console.WriteLine(SubarraySumEqualsK(new int[] { 1 }, 0));
            Console.WriteLine(SubarraySumEqualsK(new int[] { 1, 2, 1, 2, 1 }, 3));
            Console.WriteLine(SubarraySumEqualsK(new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1 }, 3));
            Console.WriteLine(SubarraySumEqualsK(new int[] { 1, 1, 1 }, 2));
            Console.WriteLine(SubarraySumEqualsK(new int[] { 1, 2, 3 }, 3));
        }

        public static int SubarraySumEqualsK(int[] nums, int k)
        {
            int left = 0, right = 0;
            int permLeft = 0, permRight = 0;
            int resultCount = 0;

            while (right < nums.Length - permRight)
            {
                int sum = 0;
                while (right < nums.Length - permRight)
                {
                    sum += nums[right];
                    right++;

                    if (sum == k)
                        resultCount++;
                }
                while (left < nums.Length - permRight)
                {
                    sum -= nums[left];
                    left++;
                    if (left == nums.Length - permRight)
                        break;
                    if (sum == k)
                        resultCount++;
                }

                permLeft++;
                permRight++;
                right = permLeft;
                left = permLeft;
            }
            return resultCount;
        }
    }
}
