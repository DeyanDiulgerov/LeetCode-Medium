using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReducingDishes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReducingDishes(new int[] { -1, -8, 0, 5, -9 }));
            Console.WriteLine(ReducingDishes(new int[] { 4, 3, 2 }));
            Console.WriteLine(ReducingDishes(new int[] { -1, -4, -5 }));
        }

        public static int ReducingDishes(int[] satisfaction)
        {
            Array.Sort(satisfaction);
            int total_satisfaction = 0;
            int sum = 0;

            for (int i = satisfaction.Length - 1; i >= 0; i--)
            {
                if (total_satisfaction > total_satisfaction + sum + satisfaction[i])
                    break;
                sum += satisfaction[i];
                total_satisfaction += sum;
            }

            return total_satisfaction;
        }
    }
}
