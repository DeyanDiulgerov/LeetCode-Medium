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
            int max = 0;
            var list = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!list.Contains(s[i]))
                    list.Add(s[i]);
                else
                {
                    max = Math.Max(max, list.Count);

                    var index = list.IndexOf(s[i]);
                    list.RemoveRange(0, index + 1);
                    list.Add(s[i]);
                }

            }
            max = Math.Max(max, list.Count);
            return max;
        }

    }
}
