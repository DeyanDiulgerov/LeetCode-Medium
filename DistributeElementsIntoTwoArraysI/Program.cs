using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeElementsIntoTwoArraysI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", DistributeElementsIntoTwoArraysI(new int[] { 2, 1, 3 })));
            Console.WriteLine(String.Join(",", DistributeElementsIntoTwoArraysI(new int[] { 5, 4, 3, 8 })));
        }
        public static int[] DistributeElementsIntoTwoArraysI(int[] nums)
        {
            var arr1 = new List<int>();
            var arr2 = new List<int>();
            var result = new List<int>();
            arr1.Add(nums[0]);
            arr2.Add(nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                if (arr1.Last() > arr2.Last())
                    arr1.Add(nums[i]);
                else
                    arr2.Add(nums[i]);
            }
            foreach (var num in arr1)
                result.Add(num);
            foreach (var num in arr2)
                result.Add(num);
            return result.ToArray();
        }
    }
}
