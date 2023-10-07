using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCharactersByFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortCharactersByFrequency("tree"));
            Console.WriteLine(SortCharactersByFrequency("cccaaa"));
            Console.WriteLine(SortCharactersByFrequency("Aabb"));
        }
        public static string SortCharactersByFrequency(string s)
        {
            var letterAndFrequencyDict = new Dictionary<char, int>();
            var result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (!letterAndFrequencyDict.ContainsKey(s[i]))
                    letterAndFrequencyDict.Add(s[i], 1);
                else
                    letterAndFrequencyDict[s[i]]++;
            }

            foreach (var kvp in letterAndFrequencyDict.OrderByDescending(x => x.Value))
            {
                for (int i = 0; i < kvp.Value; i++)
                    result += kvp.Key;
            }

            return result;
        }
    }
}
