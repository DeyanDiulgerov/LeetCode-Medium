using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsOnABoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var board1 = new char[][]
            {
                new char[] {'X', '.', '.' ,'X'},
                new char[] {'.', '.', '.' ,'X'},
                new char[] {'.', '.', '.' ,'X'},
            };
            var board2 = new char[][]
            {
                new char[] {'.'},
            };
            var board3 = new char[][]
            {
                new char[] {'X', 'X', 'X'},
            };
            Console.WriteLine(BattleshipsOnABoard(board3));
            Console.WriteLine(BattleshipsOnABoard(board1));
            Console.WriteLine(BattleshipsOnABoard(board2));
        }
        public static int BattleshipsOnABoard(char[][] board)
        {
            int m = board.Length;
            int n = board[0].Length;
            // $"{x},{y}"
            var coveredPositions = new List<string>();
            int resultCount = 0;

            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    var currPos = $"{row},{col}";
                    if (board[row][col] == 'X' && !coveredPositions.Contains(currPos))
                    {
                        var newPositions = CheckNeighbours(board, row, col, m, n);
                        if (newPositions.Count() == 0)
                        {
                            coveredPositions.Add($"{row},{col}");
                        }
                        else
                        {
                            newPositions = newPositions.Distinct().ToList();
                            for (int i = 0; i < newPositions.Count(); i++)
                            {
                                coveredPositions.Add(newPositions[i]);
                            }
                        }

                        resultCount++;
                    }
                }
            }
            return resultCount;
        }

        public static List<string> CheckNeighbours(char[][] board, int row, int col, int rows, int cols)
        {
            var result = new List<string>();
            int permRow = row;
            int permCol = col;
            while (row >= 1 && board[row][col] == 'X')
            {
                result.Add($"{row},{col}");
                row--;
            }
            row = permRow;
            col = permCol;
            while (row < rows && board[row][col] == 'X')
            {
                result.Add($"{row},{col}");
                row++;
            }
            row = permRow;
            col = permCol;
            while (col >= 1 && board[row][col] == 'X')
            {
                result.Add($"{row},{col}");
                col--;
            }
            row = permRow;
            col = permCol;
            while (col < cols && board[row][col] == 'X')
            {
                result.Add($"{row},{col}");
                col++;
            }
            row = permRow;
            col = permCol;

            return result;
        }
    }
}
