using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFurthestHousesWithDiffrentColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoFurthestHousesWithDiffrentColors(new int[] { 1, 1, 1, 6, 1, 1, 1 }));
            Console.WriteLine(TwoFurthestHousesWithDiffrentColors(new int[] { 1, 8, 3, 8, 3 }));
            Console.WriteLine(TwoFurthestHousesWithDiffrentColors(new int[] { 0, 1 }));
        }

        public static int TwoFurthestHousesWithDiffrentColors(int[] colors)
        {
            int i = 0, j = colors.Length - 1, n = colors.Length - 1;

            while (colors[i] == colors[n])
                i++;
            while (colors[j] == colors[0])
                j--;

            return Math.Max(j, n - i);
        }
    }
}
