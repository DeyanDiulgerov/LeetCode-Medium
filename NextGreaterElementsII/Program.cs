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
            var result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                //Console.WriteLine(String.Join(",", result));

                int j = i + 1;
                bool repeated = false;
                if (j >= nums.Length)
                {
                    j = 0;
                    repeated = true;
                }

                if (nums[i] >= nums[j])
                {
                    while (nums[i] >= nums[j])
                    {
                        j++;

                        if (j >= nums.Length)
                        {
                            j = 0;
                            repeated = true;
                        }

                        if (nums[j] > nums[i])
                            result[i] = nums[j];

                        if (i == j && repeated)
                        {
                            result[i] = -1;
                            break;
                        }

                        if (nums[j] > nums[i])
                            result[i] = nums[j];
                    }
                }
                else
                    result[i] = nums[j];
            }

            return result;
        }
    }
}
