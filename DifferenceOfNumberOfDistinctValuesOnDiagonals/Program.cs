using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceOfNumberOfDistinctValuesOnDiagonals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {3,1,5},
                new int[] {3,2,1},
            };
            var grid2 = new int[][]
            {
                new int[] {1},
            };
            foreach (var item in DifferenceOfNumberOfDistinctValuesOnDiagonals(grid1))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in DifferenceOfNumberOfDistinctValuesOnDiagonals(grid2))
                Console.WriteLine(String.Join(",", item));
        }
        public static int[][] DifferenceOfNumberOfDistinctValuesOnDiagonals(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[][] result = new int[m][];
            for (int row = 0; row < m; row++)
            {
                var resRow = new int[n];
                for (int col = 0; col < n; col++)
                {
                    var topLeftSet = new HashSet<int>();
                    var botRightSet = new HashSet<int>();
                    int tempRow = row, tempCol = col;
                    while (tempRow > 0 && tempCol > 0)
                    {
                        tempRow--;
                        tempCol--;
                        topLeftSet.Add(grid[tempRow][tempCol]);
                    }
                    tempRow = row; tempCol = col;
                    while (tempRow < m - 1 && tempCol < n - 1)
                    {
                        tempRow++;
                        tempCol++;
                        botRightSet.Add(grid[tempRow][tempCol]);
                    }
                    resRow[col] = Math.Abs(topLeftSet.Count() - botRightSet.Count());
                }
                result[row] = resRow;
            }
            return result;
        }
    }
}
