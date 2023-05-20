using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
            Console.WriteLine(LengthOfLongestSubstring("ac"));
            Console.WriteLine(LengthOfLongestSubstring("bb"));
            Console.WriteLine(LengthOfLongestSubstring("jklolbye"));
        }
        public static int LengthOfLongestSubstring(string s)
        {
            //find the length of the longest substring without repeating characters.
            //abcabcbb, bbbbb, pwwkew
            int maxLength = 0;
            var list = new List<char>();

            foreach (char c in s)
            {
                if (!list.Contains(c))
                    list.Add(c);

                else
                {
                    maxLength = Math.Max(maxLength, list.Count());

                    // remove preceding characters up to the duplicate text
                    int index = list.IndexOf(c);
                    list.RemoveRange(0, index + 1);

                    list.Add(c);
                }
            }
            return Math.Max(maxLength, list.Count);
        }

    }
}
