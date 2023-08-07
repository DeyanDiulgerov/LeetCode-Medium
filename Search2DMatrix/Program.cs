using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search2DMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new int[][]
            {
                new int[] {1,3,5,7},
                new int[] {10,11,16,20},
                new int[] {23,30,34,60}
            };

            var matrix2 = new int[][]
            {
                new int[] {1,3,5,7},
                new int[] {10,11,16,20},
                new int[] {23,30,34,60}
            };


            Console.WriteLine(Search2DMatrix(matrix1, 3));
            Console.WriteLine(Search2DMatrix(matrix2, 13));
        }

        public static bool Search2DMatrix(int[][] matrix, int target)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == target)
                        return true;
                }
            }

            return false;
        }
    }
}
