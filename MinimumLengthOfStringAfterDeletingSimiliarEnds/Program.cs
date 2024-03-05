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
    }
}
