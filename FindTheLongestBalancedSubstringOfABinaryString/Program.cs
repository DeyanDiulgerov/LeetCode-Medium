using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLongestBalancedSubstringOfABinaryString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheLongestBalancedSubstringOfABinaryString("0010"));
            Console.WriteLine(FindTheLongestBalancedSubstringOfABinaryString("01000111"));
            Console.WriteLine(FindTheLongestBalancedSubstringOfABinaryString("00111"));
            Console.WriteLine(FindTheLongestBalancedSubstringOfABinaryString("111"));
        }
        public static int FindTheLongestBalancedSubstringOfABinaryString(string s)
        {
            int zeroesCount = 0, onesCount = 0;
            int right = 0;
            int max = 0;
            string substring = "";

            while (right < s.Length)
            {
                while (right < s.Length && onesCount == 0)
                {
                    if (s[right] == '1')
                    {
                        onesCount++;
                        substring += s[right];
                        right++;
                        break;
                    }
                    substring += s[right];
                    zeroesCount++;
                    right++;
                }
                int permRight = right;

                string sorted = String.Concat(substring.OrderBy(x => x));
                if (substring == sorted && onesCount == zeroesCount)
                    max = Math.Max(max, substring.Length);

                while (right < s.Length && s[right] == '1' && onesCount < zeroesCount)
                {
                    substring += s[right];
                    right++;
                    onesCount++;
                }

                sorted = String.Concat(substring.OrderBy(x => x));
                if (substring == sorted && onesCount == zeroesCount)
                    max = Math.Max(max, substring.Length);

                while (onesCount > 0)
                {
                    if (substring[0] == '0')
                        zeroesCount--;
                    else
                        onesCount--;

                    substring = substring.Remove(0, 1);
                    sorted = String.Concat(substring.OrderBy(x => x));
                    if (substring == sorted && onesCount == zeroesCount)
                        max = Math.Max(max, substring.Length);
                }
                right = permRight;
            }
            return max;
        }
    }
}
