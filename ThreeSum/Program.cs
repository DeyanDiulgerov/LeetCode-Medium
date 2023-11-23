using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in ThreeSum(new int[] { 0, 1, 1 }))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in ThreeSum(new int[] { 0, 0, 0 }))
                Console.WriteLine(String.Join(",", item));
        }
        public static List<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums.Length <= 2)
                return result;

            int start = 0, left = 0, right = 0;
            int target = 0;
            Array.Sort(nums);

            while (start < nums.Length - 2)
            {
                target = nums[start] * -1;
                left = start + 1;
                right = nums.Length - 1;

                while (left < right)
                {
                    if (nums[left] + nums[right] > target)
                        right--;
                    else if (nums[left] + nums[right] < target)
                        left++;
                    else
                    {
                        var sum = new List<int>() { nums[start], nums[left], nums[right] };
                        result.Add(sum);

                        while (left < right && nums[left] == sum[1])
                            left++;
                        while (left < right && nums[right] == sum[2])
                            right--;
                    }
                }
                int currStart = nums[start];
                while (start < nums.Length - 2 && nums[start] == currStart)
                    start++;
            }
            return result;
        }
    }
}
