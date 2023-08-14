using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindKthLargestElementInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindKthLargestElementInAnArray(new int[] { 3, 2, 1, 5, 6, 4 }, 2));
            Console.WriteLine(FindKthLargestElementInAnArray(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4));
        }

        public static int FindKthLargestElementInAnArray(int[] nums, int k)
        {
            var listedNums = new List<int>(nums);
            listedNums.Sort();

            for (int i = 0; i < k - 1; i++)
            {
                int num = listedNums.Last();
                listedNums.Remove(num);
            }

            return listedNums.Last();
        }
    }
}
