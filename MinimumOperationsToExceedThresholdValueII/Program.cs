using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumOperationsToExceedThresholdValueII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumOperationsToExceedThresholdValueII(new int[] {
                1000000000, 999999999, 1000000000, 999999999, 1000000000, 999999999 }, 1000000000));
            Console.WriteLine(MinimumOperationsToExceedThresholdValueII(new int[] { 74, 22, 40, 86 }, 86));
            Console.WriteLine(MinimumOperationsToExceedThresholdValueII(new int[] { 62, 32, 62, 73, 58, 56, 68, 50 }, 74));
            Console.WriteLine(MinimumOperationsToExceedThresholdValueII(new int[] { 2, 11, 10, 1, 3 }, 10));
            Console.WriteLine(MinimumOperationsToExceedThresholdValueII(new int[] { 1, 1, 2, 4, 9 }, 20));
        }
        public static int MinimumOperationsToExceedThresholdValueII(int[] nums, int k)
        {
            int operations = 0;
            Array.Sort(nums);
            var listed = nums.Select(x => (long)x).ToList();
            for (int i = 0; i < listed.Count() - 1; i += 2)
            {
                if (listed[i] >= k)
                    break;
                long newNum = listed[i] * 2 + listed[i + 1];
                int index = BinarySearchIndex(newNum, listed);
                listed.Insert(index, newNum);
                operations++;
            }
            return operations;
        }
        public static int BinarySearchIndex(long newNum, List<long> listed)
        {
            int left = 0, right = listed.Count() - 1, mid = 0;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (listed[mid] == newNum)
                    return mid;
                else if (listed[mid] < newNum)
                    left = mid + 1;
                else//listed[mid] > newNum
                    right = mid - 1;
            }
            return right + 1;
        }
    }
}
