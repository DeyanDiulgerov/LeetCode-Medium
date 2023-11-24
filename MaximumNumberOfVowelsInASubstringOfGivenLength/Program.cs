using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberOfVowelsInASubstringOfGivenLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumNumberOfVowelsInASubstringOfGivenLength("iiiiiiiiiiiiiii", 5));
            Console.WriteLine(MaximumNumberOfVowelsInASubstringOfGivenLength("abciiidef", 3));
            Console.WriteLine(MaximumNumberOfVowelsInASubstringOfGivenLength("aeiou", 2));
            Console.WriteLine(MaximumNumberOfVowelsInASubstringOfGivenLength("leetcode", 3));
        }
        public static int MaximumNumberOfVowelsInASubstringOfGivenLength(string s, int k)
        {
            var allVowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            int max = 0;
            int right = k - 1;
            string newS = String.Concat(s.Take(k));

            int count = newS.Count(x => allVowels.Contains(x));
            max = Math.Max(max, count);

            while (right < s.Length - 1)
            {
                if (allVowels.Contains(newS[0]))
                    count--;
                newS = newS.Remove(0, 1);
                right++;
                if (allVowels.Contains(s[right]))
                    count++;
                newS += s[right];
                max = Math.Max(max, count);
            }
            return max;
        }
    }
}
