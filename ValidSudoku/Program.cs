using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidSudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            var board1 = new string[9][]
            {
                new string[] { "5", "3", ".", ".", "7", ".", ".", ".", "." },
                new string[] { "6",".",".","1","9","5",".",".","." },
                new string[] { ".","9","8",".",".",".",".","6","."},
                new string[] { "8",".",".",".","6",".",".",".","3" },
                new string[] {"4",".",".","8",".","3",".",".","1"},
                new string[] { "7",".",".",".","2",".",".",".","6" },
                new string[] { ".","6",".",".",".",".","2","8","." },
                new string[] { ".",".",".","4","1","9",".",".","5" },
                new string[] {".",".",".",".","8",".",".","7","9"},
            };

            var board2 = new string[9][]
            {
                new string[] { "8","3",".",".","7",".",".",".","." },
                new string[] { "6",".",".","1","9","5",".",".","."},
                new string[] { ".","9","8",".",".",".",".","6","."},
                new string[] { "8",".",".",".","6",".",".",".","3" },
                new string[] {"4",".",".","8",".","3",".",".","1"},
                new string[] {"7",".",".",".","2",".",".",".","6" },
                new string[] {".","6",".",".",".",".","2","8","."},
                new string[] { ".",".",".","4","1","9",".",".","5" },
                new string[] {".",".",".",".","8",".",".","7","9"},
            };


        }

        public static bool IsValidSudoku(char[][] board)
        {
            // board.Length == 9;
            for (int i = 0; i < board.Length; i++)
            {
                HashSet<int> rowRecords = new HashSet<int>();
                HashSet<int> colRecords = new HashSet<int>();
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (rowRecords.Contains(board[i][j])) return false;
                        rowRecords.Add(board[i][j]);
                    }
                    if (board[j][i] != '.')
                    {
                        if (colRecords.Contains(board[j][i])) return false;
                        colRecords.Add(board[j][i]);
                    }
                }
            }

            //Checking each 3x3 square
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    HashSet<int> sqRecords = new HashSet<int>();
                    for (int m = i; m < i + 3; m++)
                    {
                        for (int n = j; n < j + 3; n++)
                        {
                            if (board[m][n] == '.') continue;
                            if (sqRecords.Contains(board[m][n])) return false;
                            sqRecords.Add(board[m][n]);
                        }
                    }
                    j += 2;
                }
                i += 2;
            }

            return true;
        }
    }
}
