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
            int index = 0;
            int left = 0, right = 1;
            while(right <= nums.Length)
                {
                while(right < nums.Length && nums[left] == nums[right])
                    right++;
                if(right - left != 1)
                {
                    nums[index] = nums[left];
                    index++;
                }
                nums[index] = nums[left];
                index++;
                left = right;
                right++;
            }
            return index;
        }
    }
}
