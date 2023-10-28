using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAPeakElementII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mat1 = new int[][]
            {
                new int[] {1,4},
                new int[] {3,2}
            };
            var mat2 = new int[][]
           {
                new int[] {10,20,15},
                new int[] {21,30,14},
                new int[] {7,16,32},
           };
            var mat3 = new int[][]
            {
                new int[] {1,2,3,4,5,6,7,8},
                new int[] {2,3,4,5,6,7,8,9},
                new int[] {3,4,5,6,7,8,9,10},
                new int[] {4,5,6,7,8,9,10,11},
            };
            var mat4 = new int[][]
           {
                new int[] {2,3,4,5},
           };

            Console.WriteLine(String.Join(",", FindAPeakElementII(mat4)));
            Console.WriteLine(String.Join(",", FindAPeakElementII(mat3)));
            Console.WriteLine(String.Join(",", FindAPeakElementII(mat1)));
            Console.WriteLine(String.Join(",", FindAPeakElementII(mat2)));
        }
        public static int[] FindAPeakElementII(int[][] mat)
        {
            if (mat[0].Length == 1)
                return new int[] { 0, 0 };
            if (mat.Length == 1)
            {
                for (int i = 0; i < mat[0].Length; i++)
                {
                    if (i == 0)
                    {
                        if (mat[0][i] > mat[0][i + 1])
                            return new int[] { 0, 0 };
                    }
                    else if (i == mat[0].Length - 1)
                    {
                        if (mat[0][i] > mat[0][i - 1])
                            return new int[] { 0, i };
                    }
                    else
                    {
                        if (mat[0][i] > mat[0][i + 1] && mat[0][i] > mat[0][i - 1])
                            return new int[] { 0, i };
                    }
                }
            }

            for (int row = 0; row < mat.Length; row++)
            {
                for (int col = 0; col < mat[row].Length; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        if (mat[row][col] > mat[row + 1][col]
                         && mat[row][col] > mat[row][col + 1])
                            return new int[] { row, col };
                    }
                    else if (row == mat.Length - 1 && col == mat[row].Length - 1)
                    {
                        if (mat[row][col] > mat[row - 1][col]
                         && mat[row][col] > mat[row][col - 1])
                            return new int[] { row, col };
                    }
                    else if (row == 0 && col == mat[row].Length - 1)
                    {
                        if (mat[row][col] > mat[row + 1][col]
                         && mat[row][col] > mat[row][col - 1])
                            return new int[] { row, col };
                    }
                    else if (row == 0)
                    {
                        if (mat[row][col] > mat[row + 1][col]
                         && mat[row][col] > mat[row][col + 1]
                         && mat[row][col] > mat[row][col - 1])
                            return new int[] { row, col };
                    }
                    else if (col == 0 && row == mat.Length - 1)
                    {
                        if (mat[row][col] > mat[row - 1][col]
                         && mat[row][col] > mat[row][col + 1])
                            return new int[] { row, col };
                    }
                    else if (col == 0)
                    {
                        if (mat[row][col] > mat[row + 1][col]
                         && mat[row][col] > mat[row - 1][col]
                         && mat[row][col] > mat[row][col + 1])
                            return new int[] { row, col };
                    }
                    else if (row == mat.Length - 1)
                    {
                        if (mat[row][col] > mat[row - 1][col]
                         && mat[row][col] > mat[row][col + 1]
                         && mat[row][col] > mat[row][col - 1])
                            return new int[] { row, col };
                    }
                    else if (col == mat[row].Length - 1)
                    {
                        if (mat[row][col] > mat[row + 1][col]
                         && mat[row][col] > mat[row - 1][col]
                         && mat[row][col] > mat[row][col - 1])
                            return new int[] { row, col };
                    }
                    else
                    {
                        if (mat[row][col] > mat[row + 1][col]
                         && mat[row][col] > mat[row - 1][col]
                         && mat[row][col] > mat[row][col + 1]
                         && mat[row][col] > mat[row][col - 1])
                            return new int[] { row, col };
                    }
                }
            }
            return new int[] { };
        }
    }
}
