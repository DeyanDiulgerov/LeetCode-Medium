using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindrome("babad"));
            Console.WriteLine(LongestPalindrome("cbbd"));
            Console.WriteLine(LongestPalindrome("jklolby"));
            Console.WriteLine(LongestPalindrome("ac"));
            Console.WriteLine(LongestPalindrome("bb"));
            Console.WriteLine(LongestPalindrome("jklolbye"));
        }
        public static string LongestPalindrome(string s)
        {
            if (s == null || s == String.Empty)
                return "";

            int maxLength = 1;
            var maxLengthStr = "";

            for (int i = 0; i < s.Length; i++)
            {
                //Odd Palindrome
                //aba, jklolbye, babad
                int L = i; int R = i;
                while (L >= 0 && R < s.Length && s[L] == s[R])
                {
                    if (R - L + 1 >= maxLength)
                    {
                        maxLength = R - L + 1;
                        maxLengthStr = s.Substring(L, maxLength);
                    }
                    L--;
                    R++;
                }

                //Even Palindrom
                //jklolby, cbdd, bb, ac

                L = i; R = i + 1;
                while (L >= 0 && R < s.Length && s[L] == s[R])
                {
                    if (R - L + 1 >= maxLength)
                    {
                        maxLength = R - L + 1;
                        maxLengthStr = s.Substring(L, maxLength);
                    }
                    L--;
                    R++;
                }
            }

            return maxLengthStr;
        }
    }
}
