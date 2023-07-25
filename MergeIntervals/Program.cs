using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var intervals1 = new int[][]
            {
                new int[] {1,3},
                new int[] {2,6},
                new int[] {8,10},
                new int[] {15,18},
            };

            var intervals2 = new int[][]
           {
                new int[] {1,4},
                new int[] {0,5},
           };

            var output2 = MergeIntervals(intervals2);
            var output1 = MergeIntervals(intervals1);

            foreach (var item in output1)
            {
                if (item != null)
                    Console.WriteLine(String.Join(",", item));
                else
                    continue;
            }

            foreach (var item in output2)
            {
                Console.WriteLine(String.Join(",", item));
            }
        }

        public static int[][] MergeIntervals(int[][] intervals)
        {
            var output = new List<int[]>();

            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });

            output.Add(intervals[0]);

            for (int i = 1; i < intervals.Length; i++)
            {
                if (output[output.Count - 1][1] >= intervals[i][0])
                {
                    if (output[output.Count - 1][1] <= intervals[i][1])
                        output[output.Count - 1][1] = intervals[i][1];
                }
                else output.Add(intervals[i]);
            }

            return output.ToArray();
        }
    }
}
