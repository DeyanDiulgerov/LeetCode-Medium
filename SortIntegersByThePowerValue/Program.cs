using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortIntegersByThePowerValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortIntegersByThePowerValue(1, 1000, 777));
            Console.WriteLine(SortIntegersByThePowerValue(12, 15, 2));
            Console.WriteLine(SortIntegersByThePowerValue(7, 11, 4));
        }
        public static int SortIntegersByThePowerValue(int lo, int hi, int k)
        {
            var allPowers = new List<int>();
            var numAndPowerDict = new Dictionary<int, int>();

            for (int i = lo; i <= hi; i++)
            {
                var testNum = i;
                int steps = 0;

                while (testNum != 1)
                {
                    if (testNum % 2 == 0)
                        testNum /= 2;
                    else
                        testNum = 3 * testNum + 1;

                    steps++;
                }

                if (!numAndPowerDict.ContainsKey(i))
                    numAndPowerDict.Add(i, steps);
            }

            foreach (var kvp in numAndPowerDict.OrderBy(x => x.Value))
                allPowers.Add(kvp.Key);

            return allPowers[k - 1];
        }
    }
}
