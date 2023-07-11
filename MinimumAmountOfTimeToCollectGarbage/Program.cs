using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumAmountOfTimeToCollectGarbage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumAmountOfTimeToCollectGarbage
                (new string[] { "G", "G" }, new int[] { 1 }));

            Console.WriteLine(MinimumAmountOfTimeToCollectGarbage
                (new string[] { "G", "P", "GP", "GG" }, new int[] { 2, 4, 3 }));

            Console.WriteLine(MinimumAmountOfTimeToCollectGarbage
                (new string[] { "MMM", "PGM", "GP" }, new int[] { 3, 10 }));
        }

        public static int MinimumAmountOfTimeToCollectGarbage(string[] garbage, int[] travel)
        {
            int lastIndexM = 0, lastIndexP = 0, lastIndexG = 0;
            int minutes = 0;

            for (var i = 0; i < garbage.Length; i++)
            {
                minutes += garbage[i].Length; // |6| + 2 + 2 + 4 + 4 + 3
                if (garbage[i].Contains('M'))
                    lastIndexM = i; // 0
                if (garbage[i].Contains('P'))
                    lastIndexP = i; // 2
                if (garbage[i].Contains('G'))
                    lastIndexG = i; // 3
            }

            for (var j = 1; j < garbage.Length; j++) // 3
            {
                if (lastIndexM >= j)
                    minutes += travel[j - 1];
                if (lastIndexP >= j)
                    minutes += travel[j - 1];
                if (lastIndexG >= j)
                    minutes += travel[j - 1];
            }

            return minutes;
        }
    }
}
