using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualRowAndColumnPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grid1 = new int[][]
            {
                new int[] {3,2,1},
                new int[] {1,7,6},
                new int[] {2,7,7},
            };
            var grid2 = new int[][]
            {
                new int[] {3,1,2,2},
                new int[] {1,4,4,5},
                new int[] {2,4,2,2},
                new int[] {2,4,2,2},
            };
            Console.WriteLine(EqualRowAndColumnPairs(grid1));
            Console.WriteLine(EqualRowAndColumnPairs(grid2));
        }

        public static int EqualRowAndColumnPairs(int[][] grid)
        {
            int counter = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                var testRowList = new List<int>();

                for (int col = 0; col < grid[row].Length; col++)
                    testRowList.Add(grid[row][col]);

                for (int c = 0; c < grid[row].Length; c++)
                {
                    var testColList = new List<int>();

                    for (int r = 0; r < grid.Length; r++)
                        testColList.Add(grid[r][c]);

                    if (testColList.SequenceEqual(testRowList))
                        counter++;
                }
            }
            return counter;
        }
    }
}
