using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var board1 = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' },
            };

            var board2 = new char[][]
            {
                new char[] { 'a' }
            };
            var board3 = new char[][]
            {
                new char[] { 'a', 'a' }
            };

            var board4 = new char[][]
           {
                new char[] { 'C', 'A', 'A' },
                new char[] { 'A', 'A', 'A' },
                new char[] { 'B', 'C', 'D' },
           };


            Console.WriteLine(WordSearch(board1, "SEE"));
            Console.WriteLine(WordSearch(board4, "AAB"));
            Console.WriteLine(WordSearch(board3, "aaa"));
            Console.WriteLine(WordSearch(board2, "a"));
            Console.WriteLine(WordSearch(board1, "ABCB"));
            Console.WriteLine(WordSearch(board1, "ABCCED"));
        }

        public static bool WordSearch(char[][] board, string word)
        {
            int m = board.Length, n = board[0].Length;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (Dfs(i, j, 0))
                        return true;
            return false;

            bool Dfs(int i, int j, int start)
            {
                if (start == word.Length)
                    return true;
                if (i < 0 || i >= m || j < 0 || j >= n || board[i][j] != word[start])
                    return false;

                char c = board[i][j];
                board[i][j] = '~';
                bool result = Dfs(i + 1, j, start + 1) || Dfs(i - 1, j, start + 1)
                           || Dfs(i, j + 1, start + 1) || Dfs(i, j - 1, start + 1);
                board[i][j] = c;
                return result;
            }
        }
    }
}
