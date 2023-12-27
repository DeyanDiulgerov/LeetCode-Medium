using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumTimeToMakeRopeColorful
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumTimeToMakeRopeColorful(
                "aaabbbabbbb", new int[] { 3, 5, 10, 7, 5, 3, 5, 5, 4, 8, 1 }));
            Console.WriteLine(MinimumTimeToMakeRopeColorful("abaac", new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(MinimumTimeToMakeRopeColorful("abc", new int[] { 1, 2, 3 }));
            Console.WriteLine(MinimumTimeToMakeRopeColorful("aabaa", new int[] { 1, 2, 3, 4, 1 }));
        }
        public static int MinimumTimeToMakeRopeColorful(string colors, int[] neededTime)
        {
            int n = neededTime.Length;
            int minResult = 0;

            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                {
                    int j = i + 1;
                    int max = 0;
                    while (j < n && colors[i] == colors[j])
                    {
                        if (j == i + 1)
                        {
                            if (neededTime[i] > neededTime[j])
                                max = neededTime[i];
                            else
                                max = neededTime[j];

                            minResult += neededTime[i];
                            minResult += neededTime[j];
                        }
                        else
                        {
                            if (neededTime[j] > max)
                                max = neededTime[j];

                            minResult += neededTime[j];
                        }
                        j++;
                    }
                    minResult -= max;
                    i = j - 1;
                }
            }
            return minResult;
        }
    }
}
