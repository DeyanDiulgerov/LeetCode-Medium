using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionArrayAccordingToGivenPivot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", PartitionArrayAccordingToGivenPivot(new int[] { 9, 12, 5, 10, 14, 3, 10 }, 10)));
            Console.WriteLine(String.Join(",", PartitionArrayAccordingToGivenPivot(new int[] { -3, 4, 3, 2 }, 2)));
        }

        public static int[] PartitionArrayAccordingToGivenPivot(int[] nums, int pivot)
        {
            var listedNums = new List<int>(nums);

            var smaller = new List<int>();
            var bigger = new List<int>();
            var pivotted = new List<int>();

            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (listedNums[i] < pivot)
                    smaller.Add(listedNums[i]);
                else if (listedNums[i] == pivot)
                    pivotted.Add(pivot);
                else
                    bigger.Add(listedNums[i]);
            }

            result.AddRange(smaller);
            result.AddRange(pivotted);
            result.AddRange(bigger);

            return result.ToArray();
        }
    }
}
