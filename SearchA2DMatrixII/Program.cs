using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchA2DMatrixII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new int[][]
            {
                new int[] { 1, 4, 7, 11, 15 },
                new int[] {2,5,8,12,19 },
                new int[] {3,6,9,16,22},
                new int[] {10,13,14,17,24 },
                new int[] {18,21,23,26,30 },
            };
            var matrix2 = new int[][]
           {
                new int[] { 1, 4, 7, 11, 15 },
                new int[] {2,5,8,12,19 },
                new int[] {3,6,9,16,22},
                new int[] {10,13,14,17,24 },
                new int[] {18,21,23,26,30 },
           };
            var matrix3 = new int[][]
          {
                new int[] {-1, 3 },
          };
            Console.WriteLine(SearchA2DMatrixII(matrix2, 26));
            Console.WriteLine(SearchA2DMatrixII(matrix3, 3));
            Console.WriteLine(SearchA2DMatrixII(matrix1, 5));
            Console.WriteLine(SearchA2DMatrixII(matrix2, 20));
        }
        public static bool SearchA2DMatrixII(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int permCol = n - 1;

            for (int row = 0; row < m; row++)
            {
                for (int col = permCol; col >= 0; col--)
                {
                    if (matrix[row][col] == target)
                        return true;
                    else if (matrix[row][col] > target)
                        continue;
                    else if (matrix[row][col] < target)
                    {
                        permCol = col;
                        break;
                    }
                }
            }

            return false;
        }
    }
}
