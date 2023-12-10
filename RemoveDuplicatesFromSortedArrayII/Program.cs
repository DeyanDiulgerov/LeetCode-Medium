using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedArrayII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicatesFromSortedArrayII(new int[] { -3, -1, -1, 0, 0, 0, 0, 0 }));
            Console.WriteLine(RemoveDuplicatesFromSortedArrayII(new int[] { 1, 1, 1, 2, 2, 3 }));
            Console.WriteLine(RemoveDuplicatesFromSortedArrayII(new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }));
            Console.WriteLine(RemoveDuplicatesFromSortedArrayII(new int[] { 1, 1, 2 }));
            Console.WriteLine(RemoveDuplicatesFromSortedArrayII(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
            Console.WriteLine(RemoveDuplicatesFromSortedArrayII(new int[] { 1, 1, 1 }));
            Console.WriteLine(RemoveDuplicatesFromSortedArrayII(new int[] { 1, 2 }));
            Console.WriteLine(RemoveDuplicatesFromSortedArrayII(new int[] { 1, 1 }));
            Console.WriteLine(RemoveDuplicatesFromSortedArrayII(new int[] { 1 }));
        }

        public static int RemoveDuplicatesFromSortedArrayII(int[] nums)
        {
            if (nums.Length <= 2)
                return nums.Length;
            if (nums.All(x => x == nums[0]))
                return nums.Take(2).Count();
            int left = 0, right = 0;
            int indexCount = 0;
            int distinctCount = 0;

            while (left < nums.Length - 1)
            {
                left = right;
                right = left + 1;
                if (right >= nums.Length)
                {
                    nums[indexCount] = nums[left];
                    distinctCount++;
                    break;
                }
                if (nums[left] == nums[right])
                {
                    nums[indexCount] = nums[left];
                    indexCount++;
                    distinctCount++;
                }
                nums[indexCount] = nums[left];
                indexCount++;
                distinctCount++;

                while (right < nums.Length - 1 && nums[left] == nums[right])
                    right++;
                if (right >= nums.Length - 1 && nums[right] == nums[right - 1])
                    break;
            }
            return nums.Take(distinctCount).Count();
        }
    }
}
