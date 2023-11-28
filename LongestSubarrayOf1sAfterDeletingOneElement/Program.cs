using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubarrayOf1sAfterDeletingOneElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 1, 0, 1, 0, 1, 0 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 1, 1, 0, 1 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 1, 1, 1 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 0, 1, 1, 1, 0, 1, 1 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 0, 0, 1, 1 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 1, 0, 0, 0, 0 }));
            Console.WriteLine(LongestSubarrayOf1sAfterDeletingOneElement(new int[] { 1, 1, 0, 0, 1, 1, 1, 0, 1 }));
        }

        //1st Improvised ??? even Idk what approach 
        public static int LongestSubarrayOf1sAfterDeletingOneElement(int[] nums)
        {
            if (!nums.Any(x => x == 0))
                return nums.Length - 1;

            int max = 0;
            bool isRemoved = false;
            int counter = 0;
            int lastCounter = 0;
            int firstCounter = 0;
            var index = 0;

            var listed = new List<int>(nums);

            for (int i = 0; i < listed.Count(); i++)
            {
                if (listed[i] == 1)
                {
                    while (listed[i] == 1)
                    {
                        counter++;
                        if (i < listed.Count() - 1)
                            i++;
                        else
                            break;
                    }
                    if (isRemoved)
                    {
                        lastCounter = counter - firstCounter;
                        isRemoved = false;
                        max = Math.Max(max, counter);
                        counter = lastCounter;
                    }
                    if (i == listed.Count() - 1)
                        break;

                    if (listed[i] == 0 && listed[i + 1] == 1)
                    {
                        firstCounter = counter;
                        isRemoved = true;
                        index = listed.IndexOf(listed[i]);
                    }
                    else if (listed[i] == 0 && listed[i + 1] == 0)
                    {
                        max = Math.Max(max, counter);
                        counter = 0;
                    }
                }
            }
            max = Math.Max(max, counter);

            return max;
        }
        //2nd-Sliding Window approach BUT worse performance
        public static int LongestSubarrayOf1sAfterDeletingOneElement(int[] nums)
        {
            if (nums.All(x => x == 1))
                return nums.Length - 1;
            if (nums.All(x => x == 0))
                return 0;
            int left = 0, right = 0;
            int max = 0;
            var tempRight = 0;

            while (right < nums.Length)
            {
                right = left + 1;
                while (left < nums.Length && nums[left] != 1)
                    left++;
                while (right <= left || (right < nums.Length && nums[right] == 1))
                    right++;
                if (left >= right || right >= nums.Length)
                {
                    // first time we cycle through
                    if (tempRight == 0)
                        max = Math.Max(max, right - left);

                    break;
                }

                tempRight = right;
                nums[right] = 1;
                while (right < nums.Length && nums[right] == 1)
                    right++;

                nums[tempRight] = 0;
                max = Math.Max(max, right - left - 1);
                left++;
            }
            max = Math.Max(max, right - left - 1);
            return max;
        }
    }
}
