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
            //board.Length == board[0].Length == 9
            // Checking each row and col
            for(int i = 0; i < 9; i++)
            {
                var seen = new HashSet<char>();
                for(int col = 0; col < 9; col++)
                {
                    if(!char.IsDigit(board[i][col]))
                        continue;
                    if(seen.Contains(board[i][col]))
                        return false;
                    seen.Add(board[i][col]);
                }
                seen = new HashSet<char>();
                for(int row = 0; row < 9; row++)
                {
                    if(!char.IsDigit(board[row][i]))
                        continue;
                    if(seen.Contains(board[row][i]))
                        return false;
                    seen.Add(board[row][i]);
                }
            }
            //Check 3 x 3 squares
            int startRow = 0, startCol = 0;
            while(startRow < 9 && startCol < 9)
            {
                var seen = new HashSet<char>();
                for(int row = startRow; row < startRow + 3; row++)
                {
                    for(int col = startCol; col < startCol + 3; col++)
                    {
                        if(!char.IsDigit(board[row][col]))
                            continue;
                        if(seen.Contains(board[row][col]))  
                            return false;
                        seen.Add(board[row][col]);
                    }
                }
                startCol += 3;
                if(startCol == 9)
                {
                    startCol = 0;
                    startRow += 3;
                }
                if(startRow == 9)
                    break;
            }
            return true;
        }
    }
}
