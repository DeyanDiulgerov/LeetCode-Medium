using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingTheUsersActiveMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = new int[][]
            {
                new int[] {0,5},
                new int[] {1,2},
                new int[] {0,2},
                new int[] {0,5},
                new int[] {1,3},
            };

            var input2 = new int[][]
            {
                new int[] {1,1},
                new int[] {2,2},
                new int[] {2,3},
            };

            var logs1 = FindingTheUsersActiveMinutes(input1, 5);
            var logs2 = FindingTheUsersActiveMinutes(input2, 4);

            Console.WriteLine(String.Join(",", logs1));
            Console.WriteLine(String.Join(",", logs2));
        }

        public static int[] FindingTheUsersActiveMinutes(int[][] logs, int k)
        {
            var resultList = new List<int>(k);
            var userAndMinutes = new Dictionary<int, HashSet<int>>();

            foreach (var item in logs)
            {
                var testHS = new HashSet<int>();
                testHS.Add(item[1]);

                if (!userAndMinutes.ContainsKey(item[0]))
                    userAndMinutes.Add(item[0], testHS);
                else
                    userAndMinutes[item[0]].Add(item[1]);
            }

            for (int i = 0; i < k; i++)
                resultList.Add(0);

            var valueCount = new List<int>();

            foreach (var kvp in userAndMinutes.OrderBy(x => x.Key))
                valueCount.Add(kvp.Value.Count());

            foreach (var item in valueCount)
                resultList[item - 1] = valueCount.Where(x => x == item).Count();

            return resultList.ToArray();
        }
    }
}
