using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNicePairsInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountNicePairsInAnArray(new int[] { 493403445, 299010992, 457653752, 190736144, 5362635, 443020344, 276887723, 89955998, 380390071 }));
            Console.WriteLine(CountNicePairsInAnArray(new int[] { 42, 11, 1, 97 }));
            Console.WriteLine(CountNicePairsInAnArray(new int[] { 13, 10, 35, 24, 76 }));
        }
        public static int CountNicePairsInAnArray(int[] nums)
        {
            const int MOD = 1000000007;
            var numPairsCountMap = new Dictionary<long, int>();

            foreach (var num in nums)
            {
                long rev = Reverse(num);
                long firstNum = (long)num - rev;

                if (!numPairsCountMap.ContainsKey(firstNum))
                    numPairsCountMap.Add(firstNum, 1);
                else
                    numPairsCountMap[firstNum]++;
            }

            int count = 0;

            foreach (var kvp in numPairsCountMap)
            {
                long freq = kvp.Value;
                count = (int)((count + freq * (freq - 1) / 2) % MOD);
            }
            return count;
        }
        public static long Reverse(int n)
        {
            string rev = "";
            var strN = n.ToString();
            for (int i = strN.Length - 1; i >= 0; i--)
                rev += strN[i];

            return long.Parse(rev);
        }
    }
}
