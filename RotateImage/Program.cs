using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateImage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9},
            };
            var matrix2 = new int[][]
            {
                new int[] {5,1,9,11},
                new int[] {2,4,8,10},
                new int[] {13,3,6,7},
                new int[] {15,14,12,16},
            };


            foreach (var item in RotateImage(matrix1))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in RotateImage(matrix2))
                Console.WriteLine(String.Join(",", item));
        }

        public static int[][] RotateImage(int[][] matrix)
        {
            int n = matrix.Length;
            int counter = matrix.Length - 1;
            var tempMatrix = new int[matrix.Length][];

            for (int row = 0; row < n; row++)
            {
                var tempArr = new int[matrix[row].Length];
                for (int col = 0; col < matrix[row].Length; col++)
                    tempArr[col] = matrix[row][col];

                tempMatrix[row] = tempArr;
            }

            int tempCount = 0;
            for (int c = counter; c >= 0; c--)
            {
                for (int r = 0; r < matrix[c].Length; r++)
                    matrix[r][c] = tempMatrix[tempCount][r];

                tempCount++;
            }

            return matrix;
        }
    }
}
