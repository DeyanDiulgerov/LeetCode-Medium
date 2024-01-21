using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumAddToMakeParenthesesValid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumAddToMakeParenthesesValid("())"));
            Console.WriteLine(MinimumAddToMakeParenthesesValid("((("));
        }
        public static int MinimumAddToMakeParenthesesValid(string s)
        {
            int n = -1;

            while (n != s.Length)
            {
                n = s.Length;

                s = s
                    .Replace("()", "")
                    .Replace("[]", "")
                    .Replace("{}", "");
            }
            return s.Length;
        }
    }
}
