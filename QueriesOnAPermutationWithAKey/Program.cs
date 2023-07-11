using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueriesOnAPermutationWithAKey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", QueriesOnAPermutationWithAKey(new int[] { 3, 1, 2, 1 }, 5)));
            Console.WriteLine(String.Join(",", QueriesOnAPermutationWithAKey(new int[] { 4, 1, 2, 2 }, 4)));
            Console.WriteLine(String.Join(",", QueriesOnAPermutationWithAKey(new int[] { 7, 5, 5, 8, 3 }, 8)));
        }

        public static int[] QueriesOnAPermutationWithAKey(int[] queries, int m)
        {
            var resultList = new List<int>();
            var permutation = new List<int>();

            for (int i = 1; i <= m; i++)
                permutation.Add(i);

            for (int i = 0; i < queries.Length; i++)
            {
                var index = permutation.IndexOf(queries[i]);

                resultList.Add(index);
                permutation.Remove(queries[i]);
                permutation.Insert(0, queries[i]);
            }

            return resultList.ToArray();
        }
    }
}
