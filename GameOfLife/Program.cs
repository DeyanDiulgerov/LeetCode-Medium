using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new int[][]
            {
                new int[] {0,1,0},
                new int[] {0,0,1},
                new int[] {1,1,1},
                new int[] {0,0,0},
            };
            var matrix2 = new int[][]
            {
                new int[] {1,1},
                new int[] {1,0},
            };
            foreach (var item in GameOfLife(matrix1))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in GameOfLife(matrix2))
                Console.WriteLine(String.Join(",", item));
        }

        public static int[][] GameOfLife(int[][] board)
        {
            int m = board.Length;
            int n = board[0].Length;

            var tempBoard = new int[m][];
            for (int i = 0; i < m; i++)
            {
                var newArr = new int[n];
                for (int j = 0; j < n; j++)
                {
                    newArr[j] = board[i][j];
                }
                tempBoard[i] = newArr;
            }
            /*foreach (var item in tempBoard)
                Console.WriteLine(String.Join(",", item));*/

            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int result = CheckNeighbourCells(tempBoard, row, col, m, n);
                    if (tempBoard[row][col] == 1)
                    {
                        if (result < 2)
                            board[row][col] = 0;
                        else if (result > 3)
                            board[row][col] = 0;
                    }
                    else
                    {
                        if (result == 3)
                            board[row][col] = 1;
                    }
                }
            }
            //Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            return board;
        }
        public static int CheckNeighbourCells(int[][] board, int row, int col, int rows, int cols)
        {
            int onesCount = 0;

            if (row > 0 && board[row - 1][col] == 1)
                onesCount++;
            if (row < rows - 1 && board[row + 1][col] == 1)
                onesCount++;
            if (col > 0 && board[row][col - 1] == 1)
                onesCount++;
            if (col < cols - 1 && board[row][col + 1] == 1)
                onesCount++;
            if (row > 0 && col > 0 && board[row - 1][col - 1] == 1)
                onesCount++;
            if (row > 0 && col < cols - 1 && board[row - 1][col + 1] == 1)
                onesCount++;
            if (row < rows - 1 && col < cols - 1 && board[row + 1][col + 1] == 1)
                onesCount++;
            if (row < rows - 1 && col > 0 && board[row + 1][col - 1] == 1)
                onesCount++;

            return onesCount;
        }
    }
}
