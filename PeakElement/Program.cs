using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Console.WriteLine(FindPeakElement(nums));
        }

        public static int FindPeakElement(int[] nums)
        {
            if (nums.Length == 1)
                return 0;

            if (nums[0] > nums[1])
                return 0;

            if (nums[nums.Length - 2] < nums[nums.Length - 1]) 
                return nums.Length - 1;

            for (int i = 1; i <= nums.Length; i++)
            {
               /* if(i - 1 <= 0)
                {
                    i = 2;
                }
                if(i + 1 >= nums.Length - 1)
                {
                    i = nums.Length - 2;
                }*/
                if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
