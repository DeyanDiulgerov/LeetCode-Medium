using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionOfAllSuffixInstructionsStayingInAGrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", ExecutionOfAllSuffixInstructionsStayingInAGrid(
               3, new int[] { 0, 1 }, "RRDDLU")));
            Console.WriteLine(String.Join(",", ExecutionOfAllSuffixInstructionsStayingInAGrid(
               2, new int[] { 1, 1 }, "LURD")));
            Console.WriteLine(String.Join(",", ExecutionOfAllSuffixInstructionsStayingInAGrid(
               1, new int[] { 0, 0 }, "LRUD")));
        }
        public static int[] ExecutionOfAllSuffixInstructionsStayingInAGrid(int n, int[] startPos, string s)
        {
            // grid == n x n;
            int m = s.Length;
            int[] resultArr = new int[m];
            int heroRow = startPos[0];
            int heroCol = startPos[1];

            for (int i = 0; i < s.Length; i++)
            {
                int j = i;
                int counter = 0;
                while (j < s.Length && heroRow >= 0 && heroRow < n && heroCol >= 0 && heroCol < n)
                {
                    switch (s[j])
                    {
                        case 'L':
                            heroCol--;
                            break;
                        case 'R':
                            heroCol++;
                            break;
                        case 'U':
                            heroRow--;
                            break;
                        case 'D':
                            heroRow++;
                            break;
                    }
                    if (heroRow >= 0 && heroRow < n && heroCol >= 0 && heroCol < n)
                        counter++;

                    j++;
                }
                resultArr[i] = counter;
                heroRow = startPos[0];
                heroCol = startPos[1];
            }
            return resultArr;
        }
    }
}
