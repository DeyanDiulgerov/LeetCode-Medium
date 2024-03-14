using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrictlyPalindromicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrictlyPalindromicNumber(9));
            Console.WriteLine(StrictlyPalindromicNumber(4));
        }
        public static bool StrictlyPalindromicNumber(int n)
        {
            for (int i = 2; i <= n - 2; i++)
            {
                string converted = ConvertNumToStringWithBase(n, i);
                if (CheckPalindrome(converted, 0, converted.Length - 1) == false)
                    return false;
            }
            return true;
        }
        public static string ConvertNumToStringWithBase(int n, int i)
        {
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                sb.Append(n % i);
                n /= i;
            }
            return sb.ToString();
        }
        public static bool CheckPalindrome(string text, int left, int right)
        {
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
