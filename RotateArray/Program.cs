using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", RotateArray(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3)));
            Console.WriteLine(String.Join(",", RotateArray(new int[] { -1, -100, 3, 99 }, 2)));
        }
        public static int[] RotateArray(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;

            Reverse(nums, 0, n - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, n - 1);

            return nums;
        }
        static void Reverse(int[] nums, int left, int right)
        {
            while (left < right)
            {
                var temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right--;
            }
        }
    }
}
