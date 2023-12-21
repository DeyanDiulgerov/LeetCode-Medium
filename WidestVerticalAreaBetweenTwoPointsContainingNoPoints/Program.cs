using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidestVerticalAreaBetweenTwoPointsContainingNoPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var points1 = new int[][]
            {
                new int[] {8,7},
                new int[] {9,9},
                new int[] {7,4},
                new int[] {9,7},
            };
            var points2 = new int[][]
            {
                new int[] {3,1},
                new int[] {9,0},
                new int[] {1,0},
                new int[] {1,4},
                new int[] {5,3},
                new int[] {8,8},
            };
            Console.WriteLine(WidestVerticalAreaBetweenTwoPointsContainingNoPoints(points1));
            Console.WriteLine(WidestVerticalAreaBetweenTwoPointsContainingNoPoints(points2));
        }

        public static int WidestVerticalAreaBetweenTwoPointsContainingNoPoints(int[][] points)
        {
            var allXPoints = new List<int>();
            foreach (var item in points)
            {
                allXPoints.Add(item[0]);
            }

            allXPoints.Sort();
            Console.WriteLine(String.Join(",", allXPoints));
            int max = 0;

            for (int i = 1; i < allXPoints.Count(); i++)
            {
                int newMax = allXPoints[i] - allXPoints[i - 1];
                max = Math.Max(max, newMax);
            }
            return max;
        }
    }
}
