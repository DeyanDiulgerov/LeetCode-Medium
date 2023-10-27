using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumIceCreamBars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumIceCreamBars(new int[] { 1, 3, 2, 4, 1 }, 7));
            Console.WriteLine(MaximumIceCreamBars(new int[] { 10, 6, 8, 7, 7, 8 }, 5));
            Console.WriteLine(MaximumIceCreamBars(new int[] { 1, 6, 3, 1, 2, 5 }, 20));
        }
        public static int MaximumIceCreamBars(int[] costs, int coins)
        {
            Array.Sort(costs);
            int counter = 0;

            for (int i = 0; i < costs.Length; i++)
            {
                coins -= costs[i];

                if (coins > 0)
                    counter++;
                else if (coins == 0)
                {
                    counter++;
                    return counter;
                }
                else
                    return counter;
            }

            return counter;
        }
    }
}
