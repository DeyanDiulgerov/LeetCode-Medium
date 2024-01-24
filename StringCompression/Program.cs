using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringCompression(new char[] { 'a', 'a' }));
            Console.WriteLine(StringCompression(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }));
            Console.WriteLine(StringCompression(new char[] { 'a' }));
            Console.WriteLine(StringCompression(new char[]
            {'a', 'b', 'b', 'b','b', 'b', 'b','b', 'b', 'b','b', 'b', 'b',}));
        }
        // Two pointers Approach
        public static int Compress(char[] chars)
        {
            int left = 0, right = 1;
            string substring = "";
            int indexCount = 0;

            while (right <= chars.Length)
            {
                while (right < chars.Length && chars[left] == chars[right])
                    right++;

                substring += chars[left];
                indexCount++;
                if (right - left != 1)
                    substring += right - left;
                indexCount++;
                left = right;
                right = left + 1;
            }
            for (int i = 0; i < substring.Length; i++)
            {
                chars[i] = substring[i];
            }

            Console.WriteLine(String.Join(",", chars.Take(substring.Length)));
            return substring.Length;
        }
        public static int StringCompression(char[] chars)
        {
            string newS = String.Concat(chars);
            newS = GetCompressed(newS);

            List<char> result = new List<char>();
            for (int i = 0; i < newS.Length; i++)
            {
                result.Add(newS[i]);
            }

            int takeCount = 1;
            for (int i = 0; i < chars.Length; i++)
            {
                if (i >= result.Count())
                {
                    takeCount = i;
                    break;
                }
                chars[i] = result[i];
                takeCount = i + 1;
            }
            if (takeCount == 0)
                takeCount = 1;

            return chars.Take(takeCount).Count();
        }
        public static string GetCompressed(string s)
        {
            string compressed = "";
            for (int i = 0; i < s.Length; i++)
            {
                int letterCount = 1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] != s[j])
                        break;

                    letterCount++;
                    i = j;
                }

                compressed += s[i];
                if (letterCount != 1)
                    compressed += letterCount;
            }
            return compressed;
        }
    }
}
