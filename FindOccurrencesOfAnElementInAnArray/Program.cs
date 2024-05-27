using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindOccurrencesOfAnElementInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindOccurrencesOfAnElementInAnArray(
                new int[] { 1, 3, 1, 7 }, new int[] { 1, 3, 2, 4 }, 1)));
            Console.WriteLine(String.Join(",", FindOccurrencesOfAnElementInAnArray(
                new int[] { 1, 2, 3 }, new int[] { 10 }, 5)));
        }
        public static int[] FindOccurrencesOfAnElementInAnArray(int[] nums, int[] queries, int x)
        {
            int[] res = new int[queries.Length];
            var map = new Dictionary<int, List<int>>();
            map.Add(x, new List<int>() { });
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == x)
                    map[x].Add(i);
            }
            for (int i = 0; i < queries.Length; i++)
            {
                if (queries[i] > map[x].Count)
                    res[i] = -1;
                else
                    res[i] = map[x][queries[i] - 1];
            }
            return res;
        }
    }
}
