using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideArrayIntoArraysWithMaxDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in DivideArrayIntoArraysWithMaxDifference(new int[] { 1, 3, 4, 8, 7, 9, 3, 5, 1 }, 2))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in DivideArrayIntoArraysWithMaxDifference(new int[] { 1, 3, 3, 2, 7, 3 }, 3))
                Console.WriteLine(String.Join(",", item));
        }
        public static int[][] DivideArrayIntoArraysWithMaxDifference(int[] nums, int k)
        {
            Array.Sort(nums);
            List<int[]> result = new List<int[]>();
            for (int i = 0; i < nums.Length; i += 3)
            {
                List<int> newList = new List<int>();
                for (int j = i; j < i + 3; j++)
                {
                    if (nums[j] - nums[i] <= k && newList.Count() < 3)
                        newList.Add(nums[j]);
                }
                if (newList.Count() != 3)
                    return new int[][] { };
                result.Add(newList.ToArray());
            }
            return result.ToArray();
        }
    }
}
