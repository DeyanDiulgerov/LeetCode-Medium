using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountBeautifulSubstringsI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBeautifulSubstringsI("iuhoezpooxcohtlapolo", 1));
            Console.WriteLine(CountBeautifulSubstringsI("op", 1));
            Console.WriteLine(CountBeautifulSubstringsI("eeebjoxxujuaeoqibd", 8));
            Console.WriteLine(CountBeautifulSubstringsI("baeyh", 2));
            Console.WriteLine(CountBeautifulSubstringsI("abba", 1));
            Console.WriteLine(CountBeautifulSubstringsI("bcdf", 1));
        }
        // All test cases passed
        public static int CountBeautifulSubstringsI(string s, int k)
        {
            var allVowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            var resultCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var substring = "";
                int vowels = 0, consonants = 0;
                substring += s[i];
                if (allVowels.Contains(s[i]))
                    vowels++;
                else
                    consonants++;
                for (int j = i + 1; j < s.Length; j++)
                {
                    substring += s[j];
                    if (allVowels.Contains(s[j]))
                        vowels++;
                    else
                        consonants++;

                    if (vowels == consonants
                    && (vowels * consonants) % k == 0)
                        resultCount++;
                }
            }
            return resultCount;
        }
        // 611 out of 619 Test Casses Passed
        public static int CountBeautifulSubstringsI2(string s, int k)
        {
            int left = 0, right = 1;
            int permLeft = left, permRight = right;
            var substring = "";
            var allVowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            var allSubstrings = new List<string>();
            var vowels = 0;
            var consonants = 0;

            while (permLeft < s.Length - 1)
            {
                left = permLeft;
                right = permRight;
                substring = "";
                substring += s[left];
                substring += s[right];
                vowels = substring.Count(x => allVowels.Contains(x));
                consonants = substring.Count(x => !allVowels.Contains(x));
                if (vowels == consonants && (vowels * consonants) % k == 0)
                    allSubstrings.Add(substring);
                while (right < s.Length - 1)
                {
                    right++;
                    substring += s[right];
                    if (allVowels.Contains(s[right]))
                        vowels++;
                    else
                        consonants++;

                    if (vowels == consonants && (vowels * consonants) % k == 0)
                        allSubstrings.Add(substring);
                }
                while (left < s.Length - 1)
                {
                    if (allVowels.Contains(substring[0]))
                        vowels--;
                    else
                        consonants--;
                    substring = substring.Remove(0, 1);
                    left++;

                    if (vowels == consonants && (vowels * consonants) % k == 0)
                        allSubstrings.Add(substring);
                }

                permLeft++;
                permRight++;
            }
            return allSubstrings.Distinct().Count();
        }
    }
}
