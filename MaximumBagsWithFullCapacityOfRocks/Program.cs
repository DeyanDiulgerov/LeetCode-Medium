using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumBagsWithFullCapacityOfRocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumBagsWithFullCapacityOfRocks(
                new int[] { 54, 18, 91, 49, 51, 45, 58, 54,  // capacity
                    47, 91, 90, 20, 85, 20, 90, 49, 10, 84,
                    59, 29, 40, 9, 100, 1, 64, 71, 30, 46, 91 },
                new int[] { 14, 13, 16, 44, 8, 20, 51, 15, 46,  //rocks
                    76, 51, 20, 77, 13, 14, 35, 6, 34, 34, 13,
                    3, 8, 1, 1, 61, 5, 2, 15, 18 },
                77));                                       // 77 additional rocks
            Console.WriteLine(MaximumBagsWithFullCapacityOfRocks(
                new int[] { 2, 3, 4, 5 }, new int[] { 1, 2, 4, 4 }, 2));
            Console.WriteLine(MaximumBagsWithFullCapacityOfRocks(
               new int[] { 10, 2, 2 }, new int[] { 2, 2, 0 }, 100));
        }

        public static int MaximumBagsWithFullCapacityOfRocks(int[] capacity, int[] rocks, int additionalRocks)
        {
            int result = 0;

            for (int i = 0; i < capacity.Length; i++)
                capacity[i] -= rocks[i];

            Array.Sort(capacity);

            for (int i = 0; i < capacity.Length; i++)
            {
                if (additionalRocks < capacity[i])
                    break;

                additionalRocks -= capacity[i];
                result++;
            }

            return result;
        }
    }
}
