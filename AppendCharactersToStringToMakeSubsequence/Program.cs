using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendCharactersToStringToMakeSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AppendCharactersToStringToMakeSubsequence("lbg", "g"));
            Console.WriteLine(AppendCharactersToStringToMakeSubsequence("coaching", "coding"));
            Console.WriteLine(AppendCharactersToStringToMakeSubsequence("abcde", "a"));
            Console.WriteLine(AppendCharactersToStringToMakeSubsequence("z", "abcde"));
        }
        public static int AppendCharactersToStringToMakeSubsequence(string s, string t)
        {
            int left = 0, right = 0;
            while (left < s.Length && right < t.Length)
            {
                if (s[left] == t[right])
                    right++;
                left++;
            }
            return t.Length - right;
        }
    }
}
