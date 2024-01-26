using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyDiscountEveryNOrders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier(
                3, 50, new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 100, 200, 300, 400, 300, 200, 100 });
            cashier.GetBill(new int[] { 1, 2 }, new int[] { 1, 2 });
            cashier.GetBill(new int[] { 3, 7 }, new int[] { 10, 10 });
            cashier.GetBill(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 1, 1, 1, 1, 1, 1 });
            cashier.GetBill(new int[] { 4 }, new int[] { 10 });
            cashier.GetBill(new int[] { 7, 3 }, new int[] { 10, 10 });
            cashier.GetBill(new int[] { 7, 5, 3, 1, 6, 4, 2 }, new int[] { 10, 10, 10, 9, 9, 9, 7 });
            cashier.GetBill(new int[] { 2, 3, 5 }, new int[] { 5, 3, 2 });
        }
        public class Cashier
        {
            int counter;
            int people;
            int dis;
            List<int> _products;
            List<int> _prices;
            public Cashier(int n, int discount, int[] products, int[] prices)
            {
                counter = 1;
                people = n;
                dis = discount;
                _products = new List<int>(products);
                _prices = new List<int>(prices);
            }
            public double GetBill(int[] product, int[] amount)
            {
                double totalBill = 0;
                bool addDiscount = false;
                if (people == 1)
                    addDiscount = true;
                else if (counter % people == 0 && counter != 1)
                    addDiscount = true;

                for (int i = 0; i < product.Length; i++)
                {
                    int indexPrice = _products.IndexOf(product[i]);
                    totalBill += _prices[indexPrice] * amount[i];
                }
                if (addDiscount)
                {
                    double test = (double)(100 - dis) / 100;
                    totalBill *= test;
                }

                counter++;
                Console.WriteLine(totalBill);
                return totalBill;
            }
        }
    }
}
