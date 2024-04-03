using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTheMatrixDiagonally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mat1 = new int[][]
            {
                new int[] { 3, 3, 1, 1 },
                new int[] { 2,2,1,2},
                new int[] { 1,1,1,2 },
            };
            var mat2 = new int[][]
            {
                new int[] {11,25,66,1,69,7},
                new int[] {23,55,17,45,15,52},
                new int[] {75,31,36,44,58,8},
                new int[] {22,27,33,25,68,4},
                new int[] {84,28,14,11,5,50},
            };
            foreach (var item in SortTheMatrixDiagonally(mat1))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in SortTheMatrixDiagonally(mat2))
                Console.WriteLine(String.Join(",", item));
        }
        public static int[][] SortTheMatrixDiagonally(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            HashSet<string> seen = new HashSet<string>();
            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (seen.Contains($"{row}-{col}"))
                        continue;
                    List<int> sorted = new List<int>();
                    int permRow = row;
                    int permCol = col;
                    while (row < m && col < n)
                    {
                        sorted.Add(mat[row][col]);
                        seen.Add($"{row}-{col}");
                        row++;
                        col++;
                    }
                    sorted.Sort();
                    row = permRow;
                    col = permCol;
                    int index = 0;
                    while (row < m && col < n)
                    {
                        mat[row][col] = sorted[index];
                        index++;
                        row++;
                        col++;
                    }
                    row = permRow;
                    col = permCol;
                }
            }
            return mat;
        }
    }
}
