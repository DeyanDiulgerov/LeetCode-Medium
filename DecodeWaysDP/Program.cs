using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeWaysDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecodeWaysDP("12"));
            Console.WriteLine(DecodeWaysDP("226"));
            Console.WriteLine(DecodeWaysDP("06"));
        }

        public static int DecodeWaysDP(string s)
        {
            var dp = new int[s.Length + 1];
            dp[s.Length] = 1;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '0')
                    dp[i] = 0;
                else
                    dp[i] = dp[i + 1];

                if (i + 1 < s.Length && (s[i] == '1' || (s[i] == '2'
                    && (int)Char.GetNumericValue(s[i + 1]) >= 0
                    && (int)Char.GetNumericValue(s[i + 1]) <= 6)))
                    dp[i] += dp[i + 2];
            }

            return dp[0];
        }
    }
}
