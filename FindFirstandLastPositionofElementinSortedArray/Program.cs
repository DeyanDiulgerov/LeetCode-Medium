using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFirstandLastPositionofElementinSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SearchRange(new int[] { 1, 2, 3, 3, 3, 3, 4, 5, 9 }, 3)));
            Console.WriteLine(String.Join(",", SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8)));
            Console.WriteLine(String.Join(",", SearchRange(new int[] { 1, 3 }, 1)));
            Console.WriteLine(String.Join(",", SearchRange(new int[] { 3, 3, 3 }, 3)));
            Console.WriteLine(String.Join(",", SearchRange(new int[] { 1 }, 1)));
            Console.WriteLine(String.Join(",", SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 6)));
            Console.WriteLine(String.Join(",", SearchRange(new int[] { }, 0)));
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0)
                return new int[] { -1, -1 };
            else if (nums.Length == 1 && nums.First() != target)
                return new int[] { -1, -1 };
            else if (nums.Length == 1 && nums.First() == target)
                return new int[] { 0, 0 };

            var result = new List<int>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] == target)
                    result.Add(i);
                else
                    continue;
            }

            if (result.Count() == 0)
                return new int[] { -1, -1 };

            return new int[] { result.First(), result.Last() };
        }
    }
}
