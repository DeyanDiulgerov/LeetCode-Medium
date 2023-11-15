using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", GasStation(
               new int[] { 2 }, new int[] { 2 })));
            Console.WriteLine(String.Join(",", GasStation(
                new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 })));
            Console.WriteLine(String.Join(",", GasStation(
                new int[] { 2, 3, 4 }, new int[] { 3, 4, 3 })));
        }
        public static int GasStation(int[] gas, int[] cost)
        {
            int n = gas.Length;
            if (n == 1 && gas[0] == cost[0])
                return 0;

            for (int i = 0; i < n; i++)
            {
                if (gas[i] <= cost[i] || gas[i] == 0)
                    continue;
                else
                {
                    var currGas = gas[i];

                    for (int j = i; j < gas.Length + 1; j++)
                    {
                        currGas -= cost[j];
                        j++;
                        if (currGas < 0)
                            break;
                        if (j >= gas.Length)
                            j = 0;
                        if (j == i)
                            return i;
                        currGas += gas[j];
                        j--;
                    }
                }

            }
            return -1;
        }
    }
}
