using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfVisiblePeopleInQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", NumberOfVisiblePeopleInQueue
                (new int[] { 2 })));
            Console.WriteLine(String.Join(",", NumberOfVisiblePeopleInQueue
                (new int[] { 4, 3, 2, 1 })));
            Console.WriteLine(String.Join(",", NumberOfVisiblePeopleInQueue
                (new int[] { 10, 6, 8, 5, 11, 9 })));
            Console.WriteLine(String.Join(",", NumberOfVisiblePeopleInQueue
                (new int[] { 5, 1, 2, 3, 10 })));
        }
        public static int[] NumberOfVisiblePeopleInQueue(int[] heights)
        {
            if (heights.Length == 1)
                return new int[] { 0 };
            if (heights.Length == 2)
                return new int[] { 1, 0 };

            int n = heights.Length;
            var result = new int[n];

            result[n - 1] = 0;
            result[n - 2] = 1;

            for (int i = 0; i < n - 2; i++)
            {
                int counter = 1;
                int biggest = 0;

                for (int j = i + 1; j < n; j++)
                {
                    if (heights[j] > heights[i])
                    {
                        if (counter > 1)
                            counter++;
                        break;
                    }
                    else if (heights[j] < biggest)
                        continue;
                    else if (heights[j] < heights[i])
                    {
                        counter++;
                        if (heights[j] > biggest)
                            biggest = heights[j];
                    }
                }

                if (counter > 1)
                    counter--;

                result[i] = counter;
            }
            return result;
        }
    }
}
