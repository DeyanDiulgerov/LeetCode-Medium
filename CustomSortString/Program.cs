using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSortString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CustomSortString("hucw",
                "utzoampdgkalexslxoqfkdjoczajxtuhqyxvlfatmptqdsocht" +
                "dzgypsfkgqwbgqbcamdqnqztaqhqanirikahtmalzqjjxtqfnh"));

            Console.WriteLine(CustomSortString("exv", "xwvee"));
            Console.WriteLine(CustomSortString("kqep", "pekeq"));
            Console.WriteLine(CustomSortString("cba", "abcd"));
            Console.WriteLine(CustomSortString("cbafg", "abcd"));
        }

        public static string CustomSortString(string order, string s)
        {
            var result = "";

            for (int i = 0; i < order.Length; i++)
            {
                if (s.Contains(order[i]))
                {
                    for (int j = 0; j < s.Count(x => x == order[i]); j++)
                        result += order[i];
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (!result.Contains(s[i]))
                {
                    for (int j = 0; j < s.Count(x => x == s[i]); j++)
                        result += s[i];
                }
            }

            return result;
        }
    }
}
