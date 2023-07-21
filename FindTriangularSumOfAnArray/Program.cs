using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTriangularSumOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTriangularSumOfAnArray(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(FindTriangularSumOfAnArray(new int[] { 5 }));
            Console.WriteLine(FindTriangularSumOfAnArray(new int[] { 5, 5 }));
        }

        public static int FindTriangularSumOfAnArray(int[] nums)
        {
            if (nums.Length == 1)
                return nums.First();
            else if (nums.Length == 2)
                return (nums.First() + nums.Last()) % 10;

            int n = nums.Length;
            int permN = n;

            for (int i = 0; i < permN; i++)
            {
                n--;
                var newNums = new int[n];

                for (int j = 0; j < newNums.Length; j++)
                {
                    newNums[j] = (nums[j] + nums[j + 1]) % 10;
                }

                nums = newNums;

                if (nums.Length == 1)
                    break;
            }

            return nums.Last();
        }
    }
}
