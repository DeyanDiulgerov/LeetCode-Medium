using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDuplicateNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheDuplicateNumber(new int[] { 1, 3, 4, 2, 2 }));
            Console.WriteLine(FindTheDuplicateNumber(new int[] { 3, 1, 3, 4, 2 }));
        }
        public static int FindTheDuplicateNumber(int[] nums)
        {
            HashSet<int> seenNums = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (seenNums.Contains(nums[i]))
                    return nums[i];

                seenNums.Add(nums[i]);
            }
            return -1;
        }
    }
}
