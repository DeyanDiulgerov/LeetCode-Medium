using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeToBuyAndSellStockII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", BestTimeToBuyAndSellStockII(new int[] { 7, 1, 5, 3, 6, 4 })));
            Console.WriteLine(String.Join(",", BestTimeToBuyAndSellStockII(new int[] { 1, 2, 3, 4, 5 })));
            Console.WriteLine(String.Join(",", BestTimeToBuyAndSellStockII(new int[] { 7, 6, 4, 3, 1 })));
        }
        public static int BestTimeToBuyAndSellStockII(int[] prices)
        {
            int max = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    max += prices[i] - prices[i - 1];
            }
            return max;
        }
    }
}
