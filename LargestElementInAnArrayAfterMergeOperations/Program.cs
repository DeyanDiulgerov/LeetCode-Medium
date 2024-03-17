using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElementInAnArrayAfterMergeOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestElementInAnArrayAfterMergeOperations(new int[] { 2, 3, 7, 9, 3 }));
            Console.WriteLine(LargestElementInAnArrayAfterMergeOperations(new int[] { 5, 3, 3 }));
        }
        public static long LargestElementInAnArrayAfterMergeOperations(int[] nums)
        {
            List<long> listed = nums.Select(x => (long)x).ToList();
            for (int i = listed.Count() - 2; i >= 0; i--)
            {
                if (listed[i] <= listed[i + 1])
                {
                    long newNum = listed[i] + listed[i + 1];
                    listed.RemoveAt(i + 1);
                    listed.RemoveAt(i);
                    listed.Insert(i, newNum);
                    i = listed.Count() - 1;
                }
            }
            return listed.Max();
        }
    }
}
