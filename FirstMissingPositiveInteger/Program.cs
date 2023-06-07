using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMissingPositiveInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstMissingPositive(new int[] { 1, 1000 }));
            Console.WriteLine(FirstMissingPositive(new int[] { -1, -2, -60, 40, 43 }));
            Console.WriteLine(FirstMissingPositive(new int[] { 1, 2, 0 }));
            Console.WriteLine(FirstMissingPositive(new int[] { 1, 1 }));
            Console.WriteLine(FirstMissingPositive(new int[] { 3, 4, -1, 1 }));
            Console.WriteLine(FirstMissingPositive(new int[] { 7, 8, 9, 12, 11 }));
            Console.WriteLine(FirstMissingPositive(new int[] { 2, 1 }));
            Console.WriteLine(FirstMissingPositive(new int[] { -1, -2, 0 }));
            Console.WriteLine(FirstMissingPositive(new int[] { 0 }));
            Console.WriteLine(FirstMissingPositive(new int[] { 1 }));
        }

        public static int FirstMissingPositive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            int startValue = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);
                if (startValue == nums[i])
                {
                    while (set.Contains(startValue))
                    {
                        startValue++;
                    }
                }
            }
            return startValue;
        }
    }
}
