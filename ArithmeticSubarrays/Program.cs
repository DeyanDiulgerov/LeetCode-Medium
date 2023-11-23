using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticSubarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", ArithmeticSubarrays
                (new int[] { 4, 6, 5, 9, 3, 7 }, new int[] { 0, 0, 2 }, new int[] { 2, 3, 5 })));

            Console.WriteLine(String.Join(",", ArithmeticSubarrays
                (new int[] { -12, -9, -3, -12, -6, 15, 20, -25, -20, -15, -10 },
                new int[] { 0, 1, 6, 4, 8, 7 }, new int[] { 4, 4, 9, 7, 9, 10 })));

        }

        public static IList<bool> ArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            int n = nums.Length;
            int m = l.Length;
            var result = new List<bool>();

            for (int i = 0; i < m; i++)
            {
                var testList = new List<int>();
                for (int j = l[i]; j <= r[i]; j++)
                    testList.Add(nums[j]);

                testList.Sort();
                bool isArithmetic = true;

                for (int k = 1; k < testList.Count(); k++)
                    if (testList[k] - testList[k - 1] != testList[1] - testList[0])
                        isArithmetic = false;

                result.Add(isArithmetic);
            }
            return result;
        }
    }
}
