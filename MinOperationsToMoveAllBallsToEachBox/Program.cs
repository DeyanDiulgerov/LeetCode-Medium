using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOperationsToMoveAllBallsToEachBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", MinOperationsToMoveAllBallsToEachBox("110")));
            Console.WriteLine(String.Join(",", MinOperationsToMoveAllBallsToEachBox("001011")));
        }

        public static int[] MinOperationsToMoveAllBallsToEachBox(string boxes)
        {
            int n = boxes.Length;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = boxes
                    .ToArray()
                    .Select((j, k) => j == '1' && k != i ? (k < i ? Math.Abs(k - i) : k - i) : -1)
                    .Where(x => x != -1)
                    .ToArray()
                    .Sum();
            }

            return result;
        }
    }
}
