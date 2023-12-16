using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSumOfAnHourglass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] { 6,2,1,3 },
                new int[] { 4,2,1,5},
                new int[] { 9,2,8,7 },
                new int[] { 4,1,2,9 },
            };
            var grid2 = new int[][]
            {
                new int[] { 1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9},
            };
            var grid3 = new int[][]
            {
                new int[] {520626,685427,788912,800638,717251,683428},
                new int[] {23602,608915,697585,957500,154778,209236},
                new int[] {287585,588801,818234,73530,939116,252369},
            };
            Console.WriteLine(MaximumSumOfAnHourglass(grid3));
            Console.WriteLine(MaximumSumOfAnHourglass(grid1));
            Console.WriteLine(MaximumSumOfAnHourglass(grid2));
        }
        public static int MaximumSumOfAnHourglass(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int max = 0;

            for (int row = 0; row < m; row++)
            {
                int newSum = 0;
                if (row + 2 >= m)
                    break;
                for (int col = 0; col < n; col++)
                {
                    if (col + 2 >= n)
                        break;

                    newSum = 0;
                    for (int r = row; r < row + 3; r++)
                    {
                        if (r == row + 1)
                            newSum += grid[r][col + 1];
                        else
                        {
                            for (int c = col; c < col + 3; c++)
                            {
                                newSum += grid[r][c];
                            }
                        }
                    }
                    max = Math.Max(max, newSum);
                }
            }
            return max;
        }
    }
}
