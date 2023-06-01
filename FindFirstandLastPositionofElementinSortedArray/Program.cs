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
            if (nums == null || nums.Length == 0)
                return new int[] { -1, -1 };
            else if (nums.Length == 1 && nums.First() != target)
                return new int[] { -1, -1 };
            else if (nums.Length == 1 && nums.First() == target)
                return new int[] { 0, 0 };
            else
            {
                var returnList = new List<int>();
                var numbersList = new List<int>();
                var index = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                    {
                        index = i;
                        returnList.Add(i);
                        numbersList.Add(nums[i]);
                    }
                }

                if (returnList.Count == 0)
                    return new int[] { -1, -1 };
                else if (returnList.Count() == 1)
                    returnList.Add(index);

                if (numbersList.All(x => x == target) && numbersList.Count > 2)
                {
                    return new int[] { index - numbersList.Count() + 1, index };
                }

                return returnList.ToArray();
            }
        }
    }
}
