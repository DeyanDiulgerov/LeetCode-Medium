using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffrenceBetweenOnesAndZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {0,1,1},
                new int[] {1,0,1},
                new int[] {0,0,1},
            };
            var grid2 = new int[][]
            {
                new int[] {1,1,1},
                new int[] {1,1,1},
            };
            foreach (var item in DiffrenceBetweenOnesAndZeroes(grid1))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in DiffrenceBetweenOnesAndZeroes(grid2))
                Console.WriteLine(String.Join(",", item));
        }

        public static int[][] DiffrenceBetweenOnesAndZeroes(int[][] grid)
        {
            int[] row = new int[grid.Length];
            int[] col = new int[grid[0].Length];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        row[i]++;
                        col[j]++;
                    }
                }
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    grid[i][j] = row[i] + col[j] - (row.Length - row[i]) - (col.Length - col[j]);
                }
            }
            return grid;
        }
    }
}
