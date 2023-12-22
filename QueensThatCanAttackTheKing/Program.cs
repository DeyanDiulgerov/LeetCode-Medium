using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueensThatCanAttackTheKing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queens1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1,0},
                new int[] {4,0 },
                new int[] { 0,4 },
                new int[] { 3,3},
                new int[] { 2,4},
            };
            var queens2 = new int[][]
            {
                new int[] { 0,0 },
                new int[] { 1,1},
                new int[] {2,2 },
                new int[] {3,4},
                new int[] { 3,5},
                new int[] { 4,4},
                new int[] { 4,5},
            };
            foreach (var item in QueensThatCanAttackTheKing(queens1, new int[] { 0, 0 }))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in QueensThatCanAttackTheKing(queens2, new int[] { 3, 3 }))
                Console.WriteLine(String.Join(",", item));
        }

        public static IList<IList<int>> QueensThatCanAttackTheKing(int[][] queens, int[] king)
        {
            int kingRow = king[0];
            int kingCol = king[1];
            var resultList = new List<IList<int>>();
            CheckAllDirections(queens, kingRow, kingCol, resultList);

            return resultList;
        }

        public static void CheckAllDirections(
            int[][] queens, int row, int col, List<IList<int>> resultList)
        {
            int permKingRow = row;
            int permKingCol = col;
            int[] kingPosition = new int[] { row, col };

            while (col + 1 < 8)
            {
                col++;
                kingPosition = new int[] { row, col };
                if (queens.Any(x => x.SequenceEqual(kingPosition)))
                {
                    var queenPos = new List<int>();
                    queenPos.Add(row);
                    queenPos.Add(col);
                    resultList.Add(queenPos);
                    break;
                }
            }
            row = permKingRow;
            col = permKingCol;
            while (row + 1 < 8 && col + 1 < 8)
            {
                row++;
                col++;
                kingPosition = new int[] { row, col };
                if (queens.Any(x => x.SequenceEqual(kingPosition)))
                {
                    var queenPos = new List<int>();
                    queenPos.Add(row);
                    queenPos.Add(col);
                    resultList.Add(queenPos);
                    break;
                }
            }
            row = permKingRow;
            col = permKingCol;
            while (row + 1 < 8)
            {
                row++;
                kingPosition = new int[] { row, col };
                if (queens.Any(x => x.SequenceEqual(kingPosition)))
                {
                    var queenPos = new List<int>();
                    queenPos.Add(row);
                    queenPos.Add(col);
                    resultList.Add(queenPos);
                    break;
                }
            }
            row = permKingRow;
            col = permKingCol;
            while (row + 1 < 8 && col - 1 >= 0)
            {
                row++;
                col--;
                kingPosition = new int[] { row, col };
                if (queens.Any(x => x.SequenceEqual(kingPosition)))
                {
                    var queenPos = new List<int>();
                    queenPos.Add(row);
                    queenPos.Add(col);
                    resultList.Add(queenPos);
                    break;
                }
            }
            row = permKingRow;
            col = permKingCol;
            while (col - 1 >= 0)
            {
                col--;
                kingPosition = new int[] { row, col };
                if (queens.Any(x => x.SequenceEqual(kingPosition)))
                {
                    var queenPos = new List<int>();
                    queenPos.Add(row);
                    queenPos.Add(col);
                    resultList.Add(queenPos);
                    break;
                }
            }
            row = permKingRow;
            col = permKingCol;
            while (row - 1 >= 0 && col - 1 >= 0)
            {
                row--;
                col--;
                kingPosition = new int[] { row, col };
                if (queens.Any(x => x.SequenceEqual(kingPosition)))
                {
                    var queenPos = new List<int>();
                    queenPos.Add(row);
                    queenPos.Add(col);
                    resultList.Add(queenPos);
                    break;
                }
            }
            row = permKingRow;
            col = permKingCol;
            while (row - 1 >= 0)
            {
                row--;
                kingPosition = new int[] { row, col };
                if (queens.Any(x => x.SequenceEqual(kingPosition)))
                {
                    var queenPos = new List<int>();
                    queenPos.Add(row);
                    queenPos.Add(col);
                    resultList.Add(queenPos);
                    break;
                }
            }
            row = permKingRow;
            col = permKingCol;
            while (row - 1 >= 0 && col + 1 < 8)
            {
                row--;
                col++;
                kingPosition = new int[] { row, col };
                if (queens.Any(x => x.SequenceEqual(kingPosition)))
                {
                    var queenPos = new List<int>();
                    queenPos.Add(row);
                    queenPos.Add(col);
                    resultList.Add(queenPos);
                    break;
                }
            }
        }
    }
}
