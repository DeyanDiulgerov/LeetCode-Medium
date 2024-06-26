﻿using System;
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
            /*Console.WriteLine(String.Join(",", FindMedian(new int[] { 1, 3 }, new int[] { 2 })));
            Console.WriteLine(String.Join(",", FindMedian(new int[] { 1, 2 }, new int[] { 3, 4 })));
            Console.WriteLine(String.Join(",", FindMedian(new int[] { 1, 3, 5, 6 }, new int[] { 2, 4, 3 })));*/


            Console.WriteLine(LongestPalindrome("cbbd"));
            Console.WriteLine(LongestPalindrome("babad"));
            Console.WriteLine(LongestPalindrome("aabbc"));
            Console.WriteLine(LongestPalindrome("aabbbc"));
            Console.WriteLine(LongestPalindrome("ababa"));
        }
        // My Way
        public static string LongestPalindrome(string s)
        {
            int left = 0, right = s.Length;
            int permLeft = left, permRight = right;
            string result = "";
            while (permLeft < permRight)
            {
                string substring = "";
                while (left < right)
                {
                    substring += s[left];
                    bool check = IsPalindrome(substring);
                    if (check && substring.Length > result.Length)
                        result = substring;
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
        // Not Mine - Leetcode Solution
        public static string LongestPalindrome(string s)
        {
            if (s.Length == 0 || s == String.Empty)
                return "";
            else if (s.Length == 1)
                return s;
            else if (s.Length == 2 && s[0] == s[1])
                return s;
            else if (s.Length == 2 && s[0] != s[1])
                return s[0].ToString();
            else
            {
                string result = "";

                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = i; j < s.Length; j++)
                    {
                        if (j - i + 1 > result.Length && Palindrome(s, i, j))
                        {
                            result = s.Substring(i, j - i + 1);
                        }
                    }
                }

                return result;
            }
        }

        public static bool Palindrome(string s, int start, int end)
        {
            while (start <= end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}
