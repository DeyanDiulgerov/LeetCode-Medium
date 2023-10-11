using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopKFrequentWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", TopKFrequentWords
                (new string[] { "i", "love", "leetcode", "i", "love", "coding" }, 3)));
            Console.WriteLine(String.Join(",", TopKFrequentWords
                (new string[] { "i", "love", "leetcode", "i", "love", "coding" }, 2)));
            Console.WriteLine(String.Join(",", TopKFrequentWords
                (new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" }, 4)));
        }

        public static IList<string> TopKFrequentWords(string[] words, int k)
        {
            var result = new List<string>();
            var numAndFrequency = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!numAndFrequency.ContainsKey(words[i]))
                    numAndFrequency.Add(words[i], 1);
                else
                    numAndFrequency[words[i]]++;
            }

            Console.WriteLine(String.Join(",", numAndFrequency));

            int counter = 0;
            foreach (var kvp in numAndFrequency.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (counter == k)
                    break;

                result.Add(kvp.Key);
                counter++;
            }

            return result;
        }
    }
}
