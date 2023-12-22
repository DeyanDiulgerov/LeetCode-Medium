using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxAreaOfIsland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {0,0,1,0,0,0,0,1,0,0,0,0,0},
                new int[] {0,0,0,0,0,0,0,1,1,1,0,0,0},
                new int[] {0,1,1,0,1,0,0,0,0,0,0,0,0},
                new int[] {0,1,0,0,1,1,0,0,1,0,1,0,0},
                new int[] {0,1,0,0,1,1,0,0,1,1,1,0,0},
                new int[] {0,0,0,0,0,0,0,0,0,0,1,0,0},
                new int[] {0,0,0,0,0,0,0,1,1,1,0,0,0},
                new int[] {0,0,0,0,0,0,0,1,1,0,0,0,0},
            };
            var grid2 = new int[][]
            {
                new int[] {0,0,0,0,0,0,0,0},
            };
            Console.WriteLine(MaxAreaOfIsland(grid1));
            Console.WriteLine(MaxAreaOfIsland(grid2));
        }

        public static int MaxAreaOfIsland(int[][] grid)
        {
            //Added '-' between $"{row}-{col}", Previously: $"{row}{col}"
            //Because the program thought that
            //string position = $"{row}-{col}";
            //21 - 3 && 2 - 13 == both equal 213 so!list.Contains(position) skipped positions
            // r - c && r - c
            int maxCount = 0;
            int m = grid.Length;
            int n = grid[0].Length;
            List<string> seenPositions = new List<string>();
            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (grid[row][col] == 1 && !seenPositions.Contains($"{row}-{col}"))
                    {
                        List<string> newPos = new List<string>();
                        CheckNeigbours(grid, row, col, m, n, seenPositions, newPos);
                        int countNeighbours = newPos.Count();
                        maxCount = Math.Max(maxCount, countNeighbours);
                    }
                }
            }
            Console.WriteLine(String.Join(",", seenPositions));
            return maxCount;
        }

        public static void CheckNeigbours(
            int[][] grid, int row, int col, int m, int n, List<string> seenPositions, List<string> newPos)
        {
            string curr = $"{row}-{col}";
            seenPositions.Add(curr);
            newPos.Add(curr);

            if (col + 1 < n && grid[row][col + 1] == 1 && !seenPositions.Contains($"{row}-{col + 1}"))
                CheckNeigbours(grid, row, col + 1, m, n, seenPositions, newPos);
            if (col - 1 >= 0 && grid[row][col - 1] == 1 && !seenPositions.Contains($"{row}-{col - 1}"))
                CheckNeigbours(grid, row, col - 1, m, n, seenPositions, newPos);
            if (row + 1 < m && grid[row + 1][col] == 1 && !seenPositions.Contains($"{row + 1}-{col}"))
                CheckNeigbours(grid, row + 1, col, m, n, seenPositions, newPos);
            if (row - 1 >= 0 && grid[row - 1][col] == 1 && !seenPositions.Contains($"{row - 1}-{col}"))
                CheckNeigbours(grid, row - 1, col, m, n, seenPositions, newPos);
        }
    }
}
