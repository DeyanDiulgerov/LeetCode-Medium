using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WateringPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WateringPlants(new int[] { 2, 2, 3, 3 }, 5));
            Console.WriteLine(WateringPlants(new int[] { 1, 1, 1, 4, 2, 3 }, 4));
            Console.WriteLine(WateringPlants(new int[] { 7, 7, 7, 7, 7, 7, 7 }, 8));
        }

        public static int WateringPlants(int[] plants, int capacity)
        {
            int n = plants.Length;
            int stepsCounter = 0;
            int newCapacity = capacity;

            for (int i = 0; i < n; i++)
            {
                if (plants[i] <= newCapacity)
                {
                    stepsCounter++;
                    newCapacity -= plants[i];
                }
                if (i < n - 1 && plants[i + 1] > newCapacity)
                {
                    stepsCounter += (i + 1) * 2;
                    newCapacity = capacity;
                }
            }

            return stepsCounter;
        }
    }
}
