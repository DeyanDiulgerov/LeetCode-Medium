using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfIslands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new char[][]
            {
                new char[] {'1', '1', '1', '1', '0'},
                new char[] {'1', '1', '0', '1', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '0', '0', '0'},
            };
            var grid2 = new char[][]
           {
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '1', '0', '0'},
                new char[] {'0', '0', '0', '1', '1'},
           };
            Console.WriteLine(NumberOfIslands(grid1));
            Console.WriteLine(NumberOfIslands(grid2));
        }

        public static int NumberOfIslands(char[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int resultCount = 0;

            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (grid[row][col] == '1')
                    {
                        resultCount++;
                        CheckNeighbours(grid, row, col, m, n);
                    }
                }
            }
            return resultCount;
        }
        public static void CheckNeighbours(
            char[][] grid, int row, int col, int rows, int cols)
        {
            if (IsValidCell(grid, row, col, rows, cols))
            {
                grid[row][col] = '0';
                CheckNeighbours(grid, row + 1, col, rows, cols);
                CheckNeighbours(grid, row - 1, col, rows, cols);
                CheckNeighbours(grid, row, col + 1, rows, cols);
                CheckNeighbours(grid, row, col - 1, rows, cols);
            }
        }
        private static bool IsValidCell(char[][] grid, int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols && grid[row][col] == '1';
        }
    }
}
