using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBlockSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mat1 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9},
            };
            var mat2 = new int[][]
            {
                new int[] {67,64,78},
                new int[] {99,98,38},
                new int[] {82,46,46},
                new int[] {6,52,55},
                new int[] {55,99,45},
            };
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$");
            foreach (var item in MatrixBlockSum(mat2, 3))
                Console.WriteLine(String.Join(",", item));
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$");
            foreach (var item in MatrixBlockSum(mat1, 1))
                Console.WriteLine(String.Join(",", item));
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$");
            foreach (var item in MatrixBlockSum(mat1, 2))
                Console.WriteLine(String.Join(",", item));
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$");
        }
        public static int[][] MatrixBlockSum(int[][] mat, int k)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            int[][] resultMatrix = new int[m][];

            for (int row = 0; row < m; row++)
            {
                var newRow = new int[n];
                for (int col = 0; col < n; col++)
                {
                    int newSum = 0;
                    int startRow = Math.Max(0, row - k);
                    int startCol = Math.Max(0, col - k);
                    int endRow = Math.Min(m, row + k + 1);
                    int endCol = Math.Min(n, col + k + 1);
                    for (int r = startRow; r < endRow; r++)
                    {
                        for (int c = startCol; c < endCol; c++)
                        {
                            newSum += mat[r][c];
                        }
                    }
                    newRow[col] = newSum;
                }
                resultMatrix[row] = newRow;
            }
            return resultMatrix;
        }
    }
}
