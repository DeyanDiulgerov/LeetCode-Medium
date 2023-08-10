using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInRotatedSortedArrayII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SearchInRotatedSortedArrayII(new int[] { 2, 5, 6, 0, 0, 1, 2 }, 0));
            Console.WriteLine(SearchInRotatedSortedArrayII(new int[] { 2, 5, 6, 0, 0, 1, 2 }, 3));
        }

        public static bool SearchInRotatedSortedArrayII(int[] nums, int target)
        {
            if (nums.Contains(target))
                return true;
            else
                return false;
        }
    }
}
