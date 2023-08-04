using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordBreak("goalspecial", new List<string>() { "go", "goal", "goals", "special" }));
            Console.WriteLine(WordBreak("aaaaaaa", new List<string>() { "aaaa", "aaa" }));
            Console.WriteLine(WordBreak("leetcode", new List<string>() { "leet", "code" }));
            Console.WriteLine(WordBreak("applepenapple", new List<string>() { "apple", "pen" }));
            Console.WriteLine(WordBreak("catsandog", new List<string>() { "cats", "dog", "sand", "and", "cat" }));
        }

        public static bool WordBreak(string s, IList<string> wordDict)
        {
            int n = s.Length;
            bool[] dp = new bool[n + 1];
            dp[0] = true;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dp[j] && wordDict.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[n];
        }
    }
}
