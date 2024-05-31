using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDivisionsWithTheHighestScoreOfABinaryArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", AllDivisionsWithTheHighestScoreOfABinaryArray(new int[] { 0, 0, 1, 0 })));
            Console.WriteLine(String.Join(",", AllDivisionsWithTheHighestScoreOfABinaryArray(new int[] { 0, 0, 0 })));
            Console.WriteLine(String.Join(",", AllDivisionsWithTheHighestScoreOfABinaryArray(new int[] { 1, 1 })));
        }
        public static IList<int> AllDivisionsWithTheHighestScoreOfABinaryArray(int[] nums)
        {
            var map = new Dictionary<int, IList<int>>();
            int leftSum = 0;
            int rightSum = nums.Count(x => x == 1);
            int totalSum = leftSum + rightSum;
            map.Add(totalSum, new List<int>() { 0 });
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    leftSum++;
                else
                    rightSum--;

                totalSum = leftSum + rightSum;
                if (!map.ContainsKey(totalSum))
                    map.Add(totalSum, new List<int>() { i + 1 });
                else
                    map[totalSum].Add(i + 1);
            }
            return map
                .OrderByDescending(x => x.Key)
                .First()
                .Value;
        }
    }
}
