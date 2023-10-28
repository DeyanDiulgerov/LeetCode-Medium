using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumberIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SingleNumberIII(new int[] { 1, 2, 1, 3, 2, 5 })));
            Console.WriteLine(String.Join(",", SingleNumberIII(new int[] { -1, 0 })));
            Console.WriteLine(String.Join(",", SingleNumberIII(new int[] { 0, 1 })));
        }

        public static int[] SingleNumberIII(int[] nums)
        {
            var numAndCountDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numAndCountDict.ContainsKey(nums[i]))
                    numAndCountDict.Add(nums[i], 1);
                else
                    numAndCountDict[nums[i]]++;
            }

            var result = new List<int>();

            foreach (var kvp in numAndCountDict.Where(x => x.Value == 1))
                result.Add(kvp.Key);

            return result.ToArray();
        }
    }
}
