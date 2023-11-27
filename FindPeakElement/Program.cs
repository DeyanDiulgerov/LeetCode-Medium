using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPeakElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindPeakElement(new int[] { 1, 3, 2, 1 })));
            Console.WriteLine(String.Join(",", FindPeakElement(new int[] { 1, 2, 3, 1 })));
            Console.WriteLine(String.Join(",", FindPeakElement(new int[] { 1, 2, 1, 3, 5, 6, 4 })));
            Console.WriteLine(String.Join(",", FindPeakElement(new int[] { 4, 1, 2, 1, 2 })));
        }
        public static int FindPeakElement(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[mid + 1])
                    right = mid;
                else
                    left = mid + 1;
            }
            return left;
        }
    }
}
