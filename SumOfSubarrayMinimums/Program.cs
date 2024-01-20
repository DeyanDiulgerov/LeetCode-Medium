using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSubarrayMinimums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfSubarrayMinimums(new int[] { 3, 1, 2, 4 }));
            Console.WriteLine(SumOfSubarrayMinimums(new int[] { 11, 81, 94, 43, 3 }));
        }
        public static int SumOfSubarrayMinimums(int[] arr)
        {
            int minSum = 0;
            int mod = (int)Math.Pow(10, 9) + 7;

            for (int i = 0; i < arr.Length; i++)
            {
                int min = int.MaxValue;
                for (int j = i; j < arr.Length; j++)
                {
                    min = Math.Min(min, arr[j]);
                    minSum += min;
                }
                minSum = minSum % mod;
            }
            return minSum;
        }
    }
}
