using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubrectangleQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input1 = new int[][]
            {
                new int[] {1,2,1},
                new int[] {4,3,4},
                new int[] {3,2,1},
                new int[] {1,1,1},
            };
            var query1 = new SubrectangleQueries(input1);
            query1.GetValue(0, 2);
            query1.UpdateSubrectangle(0, 0, 3, 2, 5);
            query1.GetValue(0, 2);
            query1.GetValue(3, 1);
            query1.UpdateSubrectangle(3, 0, 3, 2, 10);
            query1.GetValue(3, 1);
            query1.GetValue(0, 2);
        }

        public class SubrectangleQueries
        {
            int[][] grid = new int[][] { };
            public SubrectangleQueries(int[][] rectangle)
            {
                int m = rectangle.Length;
                int n = rectangle[0].Length;
                grid = new int[m][];

                for (int i = 0; i < m; i++)
                {
                    var newRow = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        newRow[j] = rectangle[i][j];
                    }
                    grid[i] = newRow;
                }

                for (int row = 0; row < m; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        grid[row][col] = rectangle[row][col];
                    }
                }
            }

            public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
            {
                for (int row = row1; row < row2 + 1; row++)
                {
                    for (int col = col1; col < col2 + 1; col++)
                    {
                        grid[row][col] = newValue;
                    }
                }
                Console.WriteLine($"$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine($"Current state of our matrix:");
                foreach (var item in grid)
                    Console.WriteLine(String.Join(",", item));
                Console.WriteLine($"$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            }

            public int GetValue(int row, int col)
            {
                Console.WriteLine($"Our current Value: {grid[row][col]}");
                return grid[row][col];
            }
        }
    }
}
