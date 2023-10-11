using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopKFrequentElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", TopKFrequentElements(new int[] { 1, 1, 1, 2, 2, 3 }, 2)));
            Console.WriteLine(String.Join(",", TopKFrequentElements(new int[] { 1 }, 1)));
        }

        public static int[] TopKFrequentElements(int[] nums, int k)
        {
            var result = new int[k];
            var numAndFrequency = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numAndFrequency.ContainsKey(nums[i]))
                    numAndFrequency.Add(nums[i], 1);
                else
                    numAndFrequency[nums[i]]++;
            }

            Console.WriteLine(String.Join(",", numAndFrequency));

            int counter = 0;
            foreach (var kvp in numAndFrequency.OrderByDescending(x => x.Value))
            {
                if (counter == k)
                    break;

                result[counter] = kvp.Key;
                counter++;
            }

            return result;
        }
    }
}
