using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRotatedSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SearchRotatedSortedArray(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0));
            Console.WriteLine(SearchRotatedSortedArray(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3));
            Console.WriteLine(SearchRotatedSortedArray(new int[] { 1 }, 0));
        }

        public static int SearchRotatedSortedArray(int[] nums, int target)
        {
            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] == target)
                    return i;
            }

            return -1;
        }
    }
}
