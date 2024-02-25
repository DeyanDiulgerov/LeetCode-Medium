using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheSubstringWithMaximumCost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheSubstringWithMaximumCost("adaa", "d", new int[] { -1000 }));
            Console.WriteLine(FindTheSubstringWithMaximumCost("abc", "abc", new int[] { -1, -1, -1 }));
        }
        public static int FindTheSubstringWithMaximumCost(string s, string chars, int[] vals)
        {
            var map = new Dictionary<char, int>();
            for (int i = 1; i <= 26; i++)
            {
                char c = (char)((char)i + 96);
                if (chars.Contains(c))
                {
                    int index = chars.IndexOf(c);
                    map.Add(c, vals[index]);
                }
                else
                    map.Add(c, i);
            }
            Console.WriteLine(String.Join(",", map));
            int max = 0;
            int newMax = 0;
            for (int i = 0; i < s.Length; i++)
            {
                newMax = Math.Max(map[s[i]], map[s[i]] + newMax);
                max = Math.Max(max, newMax);
            }
            return max;
        }
    }
}
