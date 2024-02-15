using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfSubarraysThatMatchAPatternI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfSubarraysThatMatchAPatternI(new int[] { 481251768, 481251768, 481251768, 463564806 }, new int[] { 0 }));
            Console.WriteLine(NumberOfSubarraysThatMatchAPatternI(new int[] { 920961083, 152219776, 152219776 }, new int[] { -1, 0 }));
            Console.WriteLine(NumberOfSubarraysThatMatchAPatternI(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 1 }));
            Console.WriteLine(NumberOfSubarraysThatMatchAPatternI(new int[] { 1, 4, 4, 1, 3, 5, 5, 3 }, new int[] { 1, 0, -1 }));
        }
        public static int NumberOfSubarraysThatMatchAPatternI(int[] nums, int[] pattern)
        {
            int n = nums.Length;
            int m = pattern.Length;
            int resultCount = 0;
            for (int i = 0; i < n; i++)
            {
                int[] subArr = new int[m + 1];
                int index = 0;
                if (i + m + 1 > n)
                    break;
                for (int j = i; j < i + m + 1; j++)
                {
                    subArr[index] = nums[j];
                    index++;
                }
                bool isMatch = true;
                for (int k = 0; k < m; k++)
                {
                    switch (pattern[k])
                    {
                        case 1:
                            if (subArr[k + 1] <= subArr[k])
                                isMatch = false;
                            break;
                        case 0:
                            if (subArr[k + 1] != subArr[k])
                                isMatch = false;
                            break;
                        case -1:
                            if (subArr[k + 1] >= subArr[k])
                                isMatch = false;
                            break;
                    }
                }
                if (isMatch)
                    resultCount++;
            }
            return resultCount;
        }
    }
}
