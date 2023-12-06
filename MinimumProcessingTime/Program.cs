using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumProcessingTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumProcessingTime(
                new List<int>() { 121, 99 },
                new List<int>() { 287, 315, 293, 260, 333, 362, 69, 233 }));
            Console.WriteLine(MinimumProcessingTime(
                new List<int>() { 8, 10 },
                new List<int>() { 2, 2, 3, 1, 8, 7, 4, 5 }));
            Console.WriteLine(MinimumProcessingTime(
                new List<int>() { 10, 20 },
                new List<int>() { 2, 3, 1, 2, 5, 8, 4, 3 }));
        }

        public static int MinimumProcessingTime(IList<int> processorTime, IList<int> tasks)
        {
            //Sort both lists!!!
            var listedTasks = new List<int>(tasks);
            listedTasks.Sort();
            var listedPricessor = new List<int>(processorTime);
            listedPricessor.Sort();

            int max = 0;
            int startCount = 0;
            int endCount = 4;
            for (int i = 0; i < listedPricessor.Count(); i++)
            {
                var newMax = 0;

                for (int j = listedTasks.Count() - startCount - 1; j >= listedTasks.Count() - endCount; j--)
                {
                    newMax = Math.Max(newMax, listedPricessor[i] + listedTasks[j]);
                }

                startCount += 4;
                endCount += 4;
                max = Math.Max(max, newMax);
            }
            return max;
        }
    }
}
