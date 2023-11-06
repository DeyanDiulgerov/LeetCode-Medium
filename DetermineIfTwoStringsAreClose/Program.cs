using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetermineIfTwoStringsAreClose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DetermineIfTwoStringsAreClose("uau", "ssx"));
            Console.WriteLine(DetermineIfTwoStringsAreClose("abc", "bca"));
            Console.WriteLine(DetermineIfTwoStringsAreClose("a", "aa"));
            Console.WriteLine(DetermineIfTwoStringsAreClose("cabbba", "abbccc"));
            Console.WriteLine(DetermineIfTwoStringsAreClose("bbbcaa", "abbccc"));
        }

        public static bool DetermineIfTwoStringsAreClose(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;
            if (word1.Any(x => !word2.Contains(x)))
                return false;
            if (word2.Any(x => !word1.Contains(x)))
                return false;

            var firstLettersAndCountDict = new Dictionary<char, int>();
            var secondLettersAndCountDict = new Dictionary<char, int>();

            for (int i = 0; i < word1.Length; i++)
            {
                if (!firstLettersAndCountDict.ContainsKey(word1[i]))
                    firstLettersAndCountDict.Add(word1[i], 1);
                else
                    firstLettersAndCountDict[word1[i]]++;
            }
            for (int i = 0; i < word2.Length; i++)
            {
                if (!secondLettersAndCountDict.ContainsKey(word2[i]))
                    secondLettersAndCountDict.Add(word2[i], 1);
                else
                    secondLettersAndCountDict[word2[i]]++;
            }

            firstLettersAndCountDict = firstLettersAndCountDict
                .OrderBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            secondLettersAndCountDict = secondLettersAndCountDict
                .OrderBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            var firstList = new List<int>();
            var secondList = new List<int>();
            foreach (var kvp in firstLettersAndCountDict)
                firstList.Add(kvp.Value);
            foreach (var kvp in secondLettersAndCountDict)
                secondList.Add(kvp.Value);

            if (firstList.SequenceEqual(secondList))
                return true;

            return false;
        }
    }
}
