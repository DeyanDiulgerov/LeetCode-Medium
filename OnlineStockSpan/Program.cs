using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStockSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockSpanner stock = new StockSpanner();
            stock.Next(100);
            stock.Next(80);
            stock.Next(60);
            stock.Next(70);
            stock.Next(60);
            stock.Next(75);
            stock.Next(85);
        }
        public class StockSpanner
        {
            List<int> dataStock;
            public StockSpanner()
            {
                dataStock = new List<int>();
            }
            public int Next(int price)
            {
                dataStock.Add(price);
                int spanCount = 0;

                for (int i = dataStock.Count() - 1; i >= 0; i--)
                {
                    if (dataStock[i] <= price)
                        spanCount++;
                    else
                        break;
                }
                Console.WriteLine($"The last prices are: {spanCount}");
                return spanCount;
            }
        }
    }
}
