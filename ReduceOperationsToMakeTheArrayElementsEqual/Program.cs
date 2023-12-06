using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReduceOperationsToMakeTheArrayElementsEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReduceOperationsToMakeTheArrayElementsEqual(new int[] { 49995, 49999, 49993, 49997, 49996, 50000, 49991, 49998, 49992, 49994 }));
            Console.WriteLine(ReduceOperationsToMakeTheArrayElementsEqual(new int[] { 5 }));
            Console.WriteLine(ReduceOperationsToMakeTheArrayElementsEqual(new int[] { 5, 1, 3 }));
            Console.WriteLine(ReduceOperationsToMakeTheArrayElementsEqual(new int[] { 1, 1, 1 }));
            Console.WriteLine(ReduceOperationsToMakeTheArrayElementsEqual(new int[] { 1, 1, 2, 2, 3 }));
        }

        public static int ReduceOperationsToMakeTheArrayElementsEqual(int[] nums)
        {
            int operations = 0, increment = 0;
            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                    increment++;

                operations += increment;
            }
            return operations;
        }
    }
}
