using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RottingOranges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {2,1,1},
                new int[] {1,1,0},
                new int[] {0,1,1},
            };
            var grid2 = new int[][]
           {
                new int[] {2,1,1},
                new int[] {0,1,1},
                new int[] {1,0,1},
           };
            var grid3 = new int[][]
           {
                new int[] {0,2},
           };
            var grid4 = new int[][]
           {
                new int[] {2,0,1,1,1,1,1,1,1,1},
                new int[] {1,0,1,0,0,0,0,0,0,1},
                new int[] {1,0,1,0,1,1,1,1,0,1},
                new int[] {1,0,1,0,1,0,0,1,0,1},
                new int[] {1,0,1,0,1,0,0,1,0,1},
                new int[] {1,0,1,0,1,1,0,1,0,1},
                new int[] {1,0,1,0,0,0,0,1,0,1},
                new int[] {1,0,1,1,1,1,1,1,0,1},
                new int[] {1,0,0,0,0,0,0,0,0,1},
                new int[] {1,1,1,1,1,1,1,1,1,1},
           };
            var grid5 = new int[][]
           {
                new int[] {2,1,1},
                new int[] {1,1,1},
                new int[] {0,1,2},
           };
            Console.WriteLine(RottingOranges(grid5));
            Console.WriteLine(RottingOranges(grid4));
            Console.WriteLine(RottingOranges(grid1));
            Console.WriteLine(RottingOranges(grid2));
            Console.WriteLine(RottingOranges(grid3));
        }
        public static int RottingOranges(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int minutesCount = 0;

            for (int c = 0; c < 100; c++)
            {
                HashSet<string> seen = new HashSet<string>();
                bool infected = false;
                for (int row = 0; row < m; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (grid[row][col] == 2 && !seen.Contains($"{row}-{col}"))
                        {
                            if (RotNeighboursAndCount(grid, row, col, m, n, seen) == true
                                && infected == false)
                                infected = true;
                            /*foreach (var item in grid)
                                Console.WriteLine(String.Join(",", item));*/
                        }
                    }
                }
                if (infected)
                    minutesCount++;
            }
            foreach (var item in grid)
                Console.WriteLine(String.Join(",", item));
            if (grid.Any(x => x.Contains(1)))
                return -1;
            return minutesCount;
        }
        public static bool RotNeighboursAndCount(
            int[][] grid, int row, int col, int rows, int cols, HashSet<string> seen)
        {
            bool infectedOrange = false;

            if (row < rows - 1 && grid[row + 1][col] == 1)
            {
                grid[row + 1][col] = 2;
                infectedOrange = true;
                seen.Add($"{row + 1}-{col}");
            }
            if (row >= 1 && grid[row - 1][col] == 1)
            {
                grid[row - 1][col] = 2;
                infectedOrange = true;
                seen.Add($"{row - 1}-{col}");
            }
            if (col < cols - 1 && grid[row][col + 1] == 1)
            {
                grid[row][col + 1] = 2;
                infectedOrange = true;
                seen.Add($"{row}-{col + 1}");
            }
            if (col >= 1 && grid[row][col - 1] == 1)
            {
                grid[row][col - 1] = 2;
                infectedOrange = true;
                seen.Add($"{row}-{col - 1}");
            }
            return infectedOrange;
        }
    }
}
