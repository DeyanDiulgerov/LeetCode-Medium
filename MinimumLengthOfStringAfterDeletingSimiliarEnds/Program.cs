using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumLengthOfStringAfterDeletingSimiliarEnds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumLengthOfStringAfterDeletingSimiliarEnds("abbbbbbbbbbbbbbbbbbba"));
            Console.WriteLine(MinimumLengthOfStringAfterDeletingSimiliarEnds("ca"));
            Console.WriteLine(MinimumLengthOfStringAfterDeletingSimiliarEnds("cabaabac"));
            Console.WriteLine(MinimumLengthOfStringAfterDeletingSimiliarEnds("aabccabba"));
        }
        //Trim Ends Way
        public static int MinimumLengthOfStringAfterDeletingSimiliarEnds(string s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (s[0] != s[s.Length - 1])
                    break;
                s = s.TrimEnd(s[s.Length - 1]);
                if (s.Length == 0)
                    break;
                s = s.TrimStart(s[0]);
                left = 0;
                right = s.Length - 1;
            }
            return s.Length;
        }
        //Two Pointers - Four Pointers
        public static int MinimumLengthOfStringAfterDeletingSimiliarEnds2(string s)
        {
            int left = 0, right = s.Length - 1;
            int secLeft = 1, secRight = s.Length - 2;
            while (left < right)
            {
                if (s[left] != s[right])
                    break;
                while (secLeft <= secRight && s[left] == s[secLeft])
                    secLeft++;
                while (secLeft <= secRight && s[right] == s[secRight])
                    secRight--;

                s = s.Remove(secRight + 1, right - secRight);
                s = s.Remove(left, secLeft);
                left = 0;
                right = s.Length - 1;
                secLeft = left + 1;
                secRight = right - 1;
            }
            return s.Length;
        }
    }
}
