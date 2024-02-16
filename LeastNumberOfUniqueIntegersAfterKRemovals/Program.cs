using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastNumberOfUniqueIntegersAfterKRemovals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LeastNumberOfUniqueIntegersAfterKRemovals(new int[] { 5, 5, 4 }, 1));
            Console.WriteLine(LeastNumberOfUniqueIntegersAfterKRemovals(new int[] { 4, 3, 1, 1, 3, 3, 2 }, 3));
        }
        public static int LeastNumberOfUniqueIntegersAfterKRemovals(int[] arr, int k)
        {
            //  map = numAndFrequencyMap
            var map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!map.ContainsKey(arr[i]))
                    map.Add(arr[i], 1);
                else
                    map[arr[i]]++;
            }
            foreach (var kvp in map.OrderBy(x => x.Value))
            {
                if (k >= kvp.Value)
                {
                    k -= kvp.Value;
                    map.Remove(kvp.Key);
                }
            }
            return map.Count();
        }
    }
}
