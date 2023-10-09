using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumNumberOfStepsToMakeTwoStringsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumNumberOfStepsToMakeTwoStringsAnagram("bab", "aba"));
            Console.WriteLine(MinimumNumberOfStepsToMakeTwoStringsAnagram("leetcode", "practice"));
            Console.WriteLine(MinimumNumberOfStepsToMakeTwoStringsAnagram("anagram", "mangaar"));
        }
        public static int MinimumNumberOfStepsToMakeTwoStringsAnagram(string s, string t)
        {
            if (String.Concat(s.OrderBy(x => x)) == String.Concat(t.OrderBy(x => x)))
                return 0;
            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!t.Contains(s[i]))
                    counter++;
                else
                {
                    var index = t.IndexOf(s[i]);
                    t = t.Remove(index, 1);
                }
            }

            return counter;
        }
    }
}
