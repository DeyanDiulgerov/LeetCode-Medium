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
            int counter = 0;
            int max = 0;

            for (int i = 0; i < k; i++)
                if (allVowels.Contains(s[i]))
                    counter++;

            max = Math.Max(max, counter);
            int left = 0, right = k - 1;
            while (right < s.Length - 1)
            {
                if (allVowels.Contains(s[left]))
                    counter--;
                left++;
                right++;
                if (allVowels.Contains(s[right]))
                    counter++;

                max = Math.Max(max, counter);
            }
            return max;
        }
    }
}
