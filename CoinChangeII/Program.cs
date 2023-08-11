using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChangeII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CoinChangeII(5, new int[] { 1, 2, 5 }));
            Console.WriteLine(CoinChangeII(3, new int[] { 2 }));
            Console.WriteLine(CoinChangeII(10, new int[] { 10 }));
        }

        public static int CoinChangeII(int amount, int[] coins)
        {
            int[] dp = new int[amount + 1];
            dp[0] = 1;

            foreach (int coin in coins)
            {
                for (int i = coin; i <= amount; i++)
                    dp[i] += dp[i - coin];
            }

            return dp[amount];
        }
    }
}
