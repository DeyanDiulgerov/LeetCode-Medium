using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageWaitingTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers1 = new int[][]
            {
                new int[] {1,2},
                new int[] {2,5},
                new int[] {4,3},
            };
            var customers2 = new int[][]
            {
                new int[] {5,2},
                new int[] {5,4},
                new int[] {10,3},
                new int[] {20,1},
            };
            var customers3 = new int[][]
           {
                new int[] {2,3},
                new int[] {6,3},
                new int[] {7,5},
                new int[] {11,3},
                new int[] {15,2},
                new int[] {18,1},
           };

            Console.WriteLine(AverageWaitingTime(customers3));
            Console.WriteLine(AverageWaitingTime(customers1));
            Console.WriteLine(AverageWaitingTime(customers2));
        }

        public static double AverageWaitingTime(int[][] customers)
        {
            var allTimes = new List<double>();
            double newTime = 0;

            for (int i = 0; i < customers.Length; i++)
            {
                double arrival = customers[i][0];
                double prepTime = customers[i][1];
                double prepared = 0;
                double waitingTime = 0;

                if (i == 0)
                {
                    prepared = arrival + prepTime;
                    waitingTime = prepared - arrival;
                    allTimes.Add(waitingTime);
                    newTime = prepared;
                    continue;
                }

                if (newTime < arrival)
                {
                    prepared = arrival + prepTime;
                    waitingTime = prepared - arrival;
                    newTime = prepared;
                    allTimes.Add(waitingTime);
                    continue;
                }

                prepared = newTime + prepTime;
                waitingTime = prepared - arrival;
                newTime = prepared;
                allTimes.Add(waitingTime);
            }

            return allTimes.Sum() / allTimes.Count();
        }
    }
}
