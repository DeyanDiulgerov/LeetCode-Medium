using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndReplacePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindAndReplacePattern(
                new string[] { "abc", "deq", "mee", "aqq", "dkd", "ccc" }, "abb")));

            Console.WriteLine(String.Join(",", FindAndReplacePattern(
                            new string[] { "a", "b", "c" }, "a")));
        }

        public static List<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var resultList = new List<string>();
            var dict = new Dictionary<char, char>();

            foreach (string word in words)
            {
                if (word.Length != pattern.Length)
                    continue;

                for (int i = 0; i < pattern.Length; i++)
                {
                    if (dict.ContainsKey(pattern[i]) && dict[pattern[i]] != word[i])
                        break;

                    if (!dict.ContainsKey(pattern[i]) && dict.ContainsValue(word[i]))
                        break;

                    if (i == pattern.Length - 1)
                        resultList.Add(word);

                    if (!dict.ContainsKey(pattern[i]))
                        dict.Add(pattern[i], word[i]);
                }

                dict.Clear();
            }

            return resultList;
        }
    }
}
