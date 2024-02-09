using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumPathSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {1,3,1},
                new int[] {1,5,1},
                new int[] {4,2,1},
            };
            var grid2 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
            };
            Console.WriteLine(MinimumPathSum(grid1));
            Console.WriteLine(MinimumPathSum(grid2));
        }
        public static int MinimumPathSum(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == 0 && col == 0)
                        continue;
                    if (row == 0)
                    {
                        grid[row][col] += grid[row][col - 1];
                        continue;
                    }
                    if (col == 0)
                    {
                        grid[row][col] += grid[row - 1][col];
                        continue;
                    }
                    grid[row][col] += Math.Min(grid[row - 1][col], grid[row][col - 1]);
                }
            }
            return grid[m - 1][n - 1];
        }
    }
}
