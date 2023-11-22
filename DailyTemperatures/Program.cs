using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTemperatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 })));
            Console.WriteLine(String.Join(",", DailyTemperatures(new int[] { 30, 40, 50, 60 })));
            Console.WriteLine(String.Join(",", DailyTemperatures(new int[] { 30, 60, 90 })));
        }

        public static int[] DailyTemperatures(int[] temperatures)
        {
            int n = temperatures.Length;
            var result = new int[n];

            for (int i = 0; i < n; i++)
            {
                int counter = 0;
                for (int j = i + 1; j < n; j++)
                {
                    if (temperatures[i] < temperatures[j])
                    {
                        counter = j - i;
                        break;
                    }
                }
                result[i] = counter;
            }
            return result;
        }
    }
}
