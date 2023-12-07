using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumNumberOfStepsToMakeTwoStringsAnagramII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumNumberOfStepsToMakeTwoStringsAnagramII("cotxazilut", "nahrrmcchxwrieqqdwdpneitkxgnt"));
            Console.WriteLine(MinimumNumberOfStepsToMakeTwoStringsAnagramII("leetcode", "coats"));
            Console.WriteLine(MinimumNumberOfStepsToMakeTwoStringsAnagramII("night", "thing"));
        }

        public static int MinimumNumberOfStepsToMakeTwoStringsAnagramII(string s, string t)
        {
            //s = String.Concat(s.OrderBy(x => x));
            //t = String.Concat(t.OrderBy(x => x));
            var sLetterAndCountMap = new Dictionary<char, int>();
            var tLetterAndCountMap = new Dictionary<char, int>();
            int resultCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!sLetterAndCountMap.ContainsKey(s[i]))
                    sLetterAndCountMap.Add(s[i], 1);
                else
                    sLetterAndCountMap[s[i]]++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (!tLetterAndCountMap.ContainsKey(t[i]))
                    tLetterAndCountMap.Add(t[i], 1);
                else
                    tLetterAndCountMap[t[i]]++;
            }
            /* Console.WriteLine(String.Join(",", sLetterAndCountMap));
             Console.WriteLine(String.Join(",", tLetterAndCountMap));*/

            foreach (var kvp in sLetterAndCountMap)
            {
                if (tLetterAndCountMap.ContainsKey(kvp.Key)
                && tLetterAndCountMap[kvp.Key] == kvp.Value)
                    continue;
                else if (tLetterAndCountMap.ContainsKey(kvp.Key)
                    && tLetterAndCountMap[kvp.Key] != kvp.Value)
                    resultCount += Math.Abs(tLetterAndCountMap[kvp.Key] - kvp.Value);
                else /*if (!tLetterAndCountMap.ContainsKey(kvp.Key))*/
                    resultCount += kvp.Value;
            }
            foreach (var kvp in tLetterAndCountMap)
            {
                if (!sLetterAndCountMap.ContainsKey(kvp.Key))
                    resultCount += kvp.Value;
            }

            return resultCount;
        }
    }
}
