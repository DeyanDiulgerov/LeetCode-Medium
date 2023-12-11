using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOfArrayExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", ProductOfArrayExceptSelf(new int[] { 0, 0 })));
            Console.WriteLine(String.Join(",", ProductOfArrayExceptSelf(new int[] { 1, 2, 3, 4 })));
            Console.WriteLine(String.Join(",", ProductOfArrayExceptSelf(new int[] { -1, 1, 0, -3, 3 })));
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            var resultArr = new int[n];
            if (nums.Count(x => x == 0) > 1)
                return resultArr;

            var product = 1;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 0)
                    continue;
                product *= nums[i];
            }

            if(nums.Count(x => x == 0) == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    if (nums[i] == 0)
                        resultArr[i] = product;
                }
            }
            //if(nums.Count(x => x == 0) == 0)
            else
            {
                for (int i = 0; i < n; i++)
                {
                    var newNum = product / nums[i];
                    resultArr[i] = newNum;
                }
            }
            return resultArr;
        }
    }
}
