using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDiceRollsWithTargetSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfDiceRollsWithTargetSum(1, 6, 3));
            Console.WriteLine(NumberOfDiceRollsWithTargetSum(2, 6, 7));
            Console.WriteLine(NumberOfDiceRollsWithTargetSum(30, 30, 500));
        }
        public static int NumberOfDiceRollsWithTargetSum(int n, int k, int target)
        {
            var dp = new int[target + 1];
            dp[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                var tmp = new int[dp.Length];

                for (int j = 1; j <= target; j++)
                {
                    if (j > i * k) continue;

                    for (int m = 1; m <= k && m <= j; m++)
                    {
                        tmp[j] = (tmp[j] + dp[j - m]) % 1_000_000_007;
                    }
                }

                dp = tmp;
            }

            return dp[target];
        }
    }
}
