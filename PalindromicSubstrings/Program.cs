using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicSubstrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromicSubstrings("abc"));
            Console.WriteLine(PalindromicSubstrings("aaa"));
        }
        public static int PalindromicSubstrings(string s)
        {
            int left = 0, right = s.Length;
            int permLeft = left, permRight = right;
            int result = 0;
            while (permLeft < permRight)
            {
                string substring = "";
                while (left < right)
                {
                    substring += s[left];
                    bool check = IsPalindrome(substring);
                    if (check)
                        result++;
                    left++;
                }
                permLeft++;
                left = permLeft;
            }
            return result;
        }
        public static bool IsPalindrome(string text)
        {
            int left = 0, right = text.Length - 1;
            while (left < right)
            {
                if (text[left] != text[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
