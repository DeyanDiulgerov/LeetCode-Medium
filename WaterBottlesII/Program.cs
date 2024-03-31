using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBottlesII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WaterBottlesII(13, 6));
            Console.WriteLine(WaterBottlesII(10, 3));
        }
        public static int WaterBottlesII(int numBottles, int numExchange)
        {
            int emptyBottles = numBottles;
            int resultBottles = numBottles;
            numBottles = 0;
            while (numBottles + emptyBottles >= numExchange)
            {
                while (emptyBottles >= numExchange)
                {
                    emptyBottles -= numExchange;
                    numBottles++;
                    numExchange++;
                }
                resultBottles += numBottles;
                emptyBottles += numBottles;
                numBottles = 0;
            }
            return resultBottles;
        }
    }
}
