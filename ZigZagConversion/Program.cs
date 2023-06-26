using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ZigZagConversion("PAYPALISHIRING", 4));
            Console.WriteLine(ZigZagConversion("PAYPALISHIRING", 3));
        }

        public static string ZigZagConversion(string s, int numRows)
        {
            var strs = new string[numRows];

            for (int i = 0; i < numRows; i++)
                strs[i] = "";

            for (int i = 0; i < s.Length; i++)
            {
                for (int m = 0; m < numRows && i < s.Length; m++)
                {
                    strs[m] += s[i++];
                }
                for (int n = numRows - 2; n > 0 && i < s.Length; n--)
                {
                    strs[n] += s[i++];
                }
                i--;
            }

            var result = "";
            foreach (var ss in strs)
            {
                result += ss;
            }

            return result;
        }
    }
}
