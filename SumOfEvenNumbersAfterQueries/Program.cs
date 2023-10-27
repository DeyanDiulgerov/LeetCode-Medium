using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvenNumbersAfterQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queries1 = new int[][]
            {
                new int[] {1,0},
                new int[] {-3,1},
                new int[] {-4,0},
                new int[] {2,3},
            };
            var queries2 = new int[][]
           {
                new int[] {4,0},
           };

            Console.WriteLine(String.Join(",", SumOfEvenNumbersAfterQueries(new int[] { 1, 2, 3, 4 }, queries1)));
            Console.WriteLine(String.Join(",", SumOfEvenNumbersAfterQueries(new int[] { 1 }, queries2)));
        }
        public static int[] SumOfEvenNumbersAfterQueries(int[] nums, int[][] queries)
        {
            var answer = new List<int>();

            for (int i = 0; i < queries.Length; i++)
            {
                var value = queries[i][0];
                var index = queries[i][1];

                nums[index] += value;

                int sum = nums.Where(x => x % 2 == 0).Sum();
                answer.Add(sum);
            }

            return answer.ToArray();
        }
    }
}
