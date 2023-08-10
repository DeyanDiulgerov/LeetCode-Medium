using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetMatrixZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new int[][]
            {
                new int[] {1,1,1},
                new int[] {1,0,1},
                new int[] {1,1,1},
            };

            var matrix2 = new int[][]
            {
                new int[] {0,1,2,0},
                new int[] {3,4,5,2},
                new int[] {1,3,1,5},
            };
            var matrix3 = new int[][]
            {
                new int[] {0,1},
            };



            var input3 = SetMatrixZeroes(matrix3);
            var input2 = SetMatrixZeroes(matrix2);
            var input1 = SetMatrixZeroes(matrix1);

            foreach (var item in input1)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input2)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input3)
                Console.WriteLine(String.Join(",", item));
        }

        public static int[][] SetMatrixZeroes(int[][] matrix)
        {
            var usedRowCol = new List<List<int>>();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                        usedRowCol.Add(new List<int>() { i, j });
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    var testList = new List<int>() { row, col };

                    if (usedRowCol.Any(x => x.SequenceEqual(testList)) && matrix[row][col] == 0)
                    {
                        for (int i = row; i < matrix.Length; i++)
                            matrix[i][col] = 0;
                        for (int j = row; j >= 0; j--)
                            matrix[j][col] = 0;

                        for (int i = col; i < matrix[row].Length; i++)
                            matrix[row][i] = 0;
                        for (int j = col; j >= 0; j--)
                            matrix[row][j] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}
