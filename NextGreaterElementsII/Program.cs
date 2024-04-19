using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGreaterElementsII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", NextGreaterElementsII(new int[] { 1, 2, 1 })));
            Console.WriteLine(String.Join(",", NextGreaterElementsII(new int[] { 1, 2, 3, 4, 3 })));
            Console.WriteLine(String.Join(",", NextGreaterElementsII(new int[] { 1, 1, 2 })));
        }

        public static int[] NextGreaterElementsII(int[] nums)
        {
            int n = nums.Length;
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (j == n)
                        j = 0;
                    if (nums[j] > nums[i])
                    {
                        res[i] = nums[j];
                        break;
                    }
                    if (j == i)
                    {
                        res[i] = -1;
                        break;
                    }
                    if (j == n - 1)
                        j = -1;
                }
            }
            return res;
        }
    }
}
