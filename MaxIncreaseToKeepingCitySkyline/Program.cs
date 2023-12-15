using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxIncreaseToKeepingCitySkyline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {3,0,8,4 },
                new int[] {2,4,5,7 },
                new int[] {9,2,6,3 },
                new int[] {0,3,1,0 },
            };
            var grid2 = new int[][]
            {
                new int[] {0,0,0},
                new int[] {0,0,0},
                new int[] {0,0,0},
            };
            Console.WriteLine(MaxIncreaseToKeepingCitySkyline(grid1));
            Console.WriteLine(MaxIncreaseToKeepingCitySkyline(grid2));
        }
        public static int MaxIncreaseToKeepingCitySkyline(int[][] grid)
        {
            int n = grid.Length;
            int resultCount = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int maxRow = 0;
                    int maxCol = 0;

                    for (int r = 0; r < n; r++)
                    {
                        int curr = grid[r][col];
                        maxRow = Math.Max(maxRow, curr);
                    }
                    for (int c = 0; c < n; c++)
                    {
                        int curr = grid[row][c];
                        maxCol = Math.Max(maxCol, curr);
                    }

                    int skyline = Math.Min(maxRow, maxCol);
                    int blocksNeeded = skyline - grid[row][col];
                    resultCount += blocksNeeded;
                    grid[row][col] = skyline;
                }
            }
            return resultCount;
        }
    }
}
