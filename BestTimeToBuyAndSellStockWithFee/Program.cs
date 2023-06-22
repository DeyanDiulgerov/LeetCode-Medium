using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeToBuyAndSellStockWithFee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BestTimeToBuyAndSellStockWithFee(new int[] { 1, 3, 2, 8, 4, 9 }, 2));
            Console.WriteLine(BestTimeToBuyAndSellStockWithFee(new int[] { 1, 3, 7, 5, 10, 3 }, 3));
        }

        public static int BestTimeToBuyAndSellStockWithFee(int[] prices, int fee)
        {
            int min = prices[0];
            int max = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (min > prices[i])
                {
                    min = prices[i];
                }
                else if (prices[i] > min + fee)
                {
                    max += (prices[i] - min) - fee;
                    min = prices[i] - fee;
                }
            }

            return max;
        }

    }
}
