using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereWillTheBallFall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {1,1,1,-1,-1 },
                new int[] {1,1,1,-1,-1},
                new int[] {-1,-1,-1,1,1},
                new int[] {1,1,1,1,-1 },
                new int[] {-1,-1,-1,-1,-1},
            };
            var grid2 = new int[][]
           {
                new int[] {-1 },
           };
            var grid3 = new int[][]
           {
                new int[] {1,1,1,1,1,1},
                new int[] {-1,-1,-1,-1,-1,-1},
                new int[] {1,1,1,1,1,1},
                new int[] {-1,-1,-1,-1,-1,-1},
           };
            Console.WriteLine(String.Join(",", WhereWillTheBallFall(grid1)));
            Console.WriteLine(String.Join(",", WhereWillTheBallFall(grid2)));
            Console.WriteLine(String.Join(",", WhereWillTheBallFall(grid3)));
        }

        public static int[] WhereWillTheBallFall(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[] resultArr = new int[n];
            int indexCount = 0;

            for (int col = 0; col < n; col++)
            {
                int final = FinishTheBallDrop(grid, 0, col, m, n);
                resultArr[indexCount] = final;
                indexCount++;
            }
            return resultArr;
        }

        public static int FinishTheBallDrop(int[][] grid, int row, int col, int rows, int cols)
        {
            while (row < rows)
            {
                if (col + 1 < cols && grid[row][col] == 1 && grid[row][col + 1] == -1)
                    return -1;
                if (col - 1 >= 0 && grid[row][col] == -1 && grid[row][col - 1] == 1)
                    return -1;

                if (grid[row][col] == 1)
                {
                    row++;
                    col++;
                    if (col >= cols)
                        return -1;
                }
                else//grid[row][col] == -1
                {
                    row++;
                    col--;
                    if (col < 0)
                        return -1;
                }
            }
            return col;
        }
    }
}
