using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAbsoluteDiffrencesInASortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SumOfAbsoluteDiffrencesInASortedArray(new int[] { 2, 3, 5 })));
            Console.WriteLine(String.Join(",", SumOfAbsoluteDiffrencesInASortedArray(new int[] { 1, 4, 6, 8, 10 })));
        }
        public static int[] SumOfAbsoluteDiffrencesInASortedArray(int[] nums)
        {
            int n = nums.Length;
            var result = new int[n];
            var leftSum = new int[n];
            var rightSum = new int[n];

            leftSum[0] = 0;
            rightSum[n - 1] = 0;

            for (int i = 1; i < n; i++)
                leftSum[i] = leftSum[i - 1] + (nums[i] - nums[i - 1]) * i;

            for (int i = n - 2; i >= 0; i--)
                rightSum[i] = rightSum[i + 1] + (nums[i + 1] - nums[i]) * (n - i - 1);

            for (int i = 0; i < n; i++)
                result[i] = leftSum[i] + rightSum[i];

            return result;
        }
    }
}
