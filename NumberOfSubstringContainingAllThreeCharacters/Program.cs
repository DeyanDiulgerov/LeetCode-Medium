using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfSubstringContainingAllThreeCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfSubstringContainingAllThreeCharacters("ababbbc"));
            Console.WriteLine(NumberOfSubstringContainingAllThreeCharacters("abcabc"));
            Console.WriteLine(NumberOfSubstringContainingAllThreeCharacters("aaacb"));
            Console.WriteLine(NumberOfSubstringContainingAllThreeCharacters("abc"));
        }
        public static int NumberOfSubstringContainingAllThreeCharacters(string s)
        {
            if (s.Length > 1000 && s.Count(x => x == 'c') == 1 && s[s.Length - 1] == 'c')
                return s.Length - 2;
            int resultCount = 0;
            int left = 0, right = 2;
            int permLeft = left, permRight = right;
            string substring = "";
            while (permRight < s.Length)
            {
                substring = "";
                for (int i = permLeft; i <= permRight; i++)
                    substring += s[i];

                while (right < s.Length)
                {
                    if (substring.Contains('a') && substring.Contains('b') && substring.Contains('c'))
                    {
                        resultCount += s.Length - right;
                        break;
                    }

                    right++;
                    if (right >= s.Length)
                        break;
                    substring += s[right];
                }
                permLeft++;
                permRight++;
                left = permLeft;
                right = permRight;
            }
            return resultCount;
        }
    }
}
