using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestValidParentheses("(()()"));
            Console.WriteLine(LongestValidParentheses("()(()"));
            Console.WriteLine(LongestValidParentheses("()(())"));
            Console.WriteLine(LongestValidParentheses("(()()()()()()()()()()()())"));
            Console.WriteLine(LongestValidParentheses("(()"));
            Console.WriteLine(LongestValidParentheses(")()())"));
            Console.WriteLine(LongestValidParentheses(""));
        }

        public static int LongestValidParentheses(string s)
        {
            int max = 0;
            int left = 0, right = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    left++;
                else
                    right++;

                if (left == right)
                {
                    max = Math.Max(max, left * 2);
                }

                if (right > left)
                {
                    left = 0;
                    right = 0;
                }
            }

            left = 0;
            right = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '(')
                    left++;
                else
                    right++;

                if (left == right)
                {
                    max = Math.Max(max, right * 2);
                }
                if (left > right)
                {
                    left = 0;
                    right = 0;
                }
            }
            return max;
        }
    }
}
