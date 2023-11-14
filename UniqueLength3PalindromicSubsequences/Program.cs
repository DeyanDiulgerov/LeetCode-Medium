using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueLength3PalindromicSubsequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", UniqueLength3PalindromicSubsequences("aabca")));
            Console.WriteLine(String.Join(",", UniqueLength3PalindromicSubsequences("adc")));
            Console.WriteLine(String.Join(",", UniqueLength3PalindromicSubsequences("bbcbaba")));
        }

        public static int UniqueLength3PalindromicSubsequences(string s)
        {
            var sum = 0;
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                var firstIndex = s.IndexOf(ch);
                var lastIndex = s.LastIndexOf(ch);
                var hashSet = new HashSet<char>();

                for (int i = firstIndex + 1; i < lastIndex; i++)
                    hashSet.Add(s[i]);

                sum += hashSet.Count();
            }
            return sum;
        }
    }
}
