using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPlayersWithZeroOrOneLosses
{
    class Program
    {
        static void Main(string[] args)
        {
            var matches1 = new int[][]
            {
                new int[] {1,3},
                new int[] {2,3},
                new int[] {3,6},
                new int[] {5,6},
                new int[] {5,7},
                new int[] {4,5},
                new int[] {4,8},
                new int[] {4,9},
                new int[] {10,4},
                new int[] {10,9},
            };
            var matches2 = new int[][]
            {
                new int[] {2,3},
                new int[] {1,3},
                new int[] {5,4},
                new int[] {6,4},
            };

            var result1 = FindPlayersWithZeroOrOneLosses(matches1);
            var result2 = FindPlayersWithZeroOrOneLosses(matches2);

            foreach (var item in result1)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in result2)
                Console.WriteLine(String.Join(",", item));
        }
        public static IList<IList<int>> FindPlayersWithZeroOrOneLosses(int[][] matches)
        {
            var allPlayers = new HashSet<int>();

            foreach (var item in matches)
            {
                allPlayers.Add(item[0]);
                allPlayers.Add(item[1]);
            }

            var listed = new List<int>(allPlayers);
            var losersAndCountDict = new Dictionary<int, int>();
            for (int i = 0; i < listed.Count(); i++)
                losersAndCountDict.Add(listed[i], 0);

            foreach (var item in matches)
            {
                var player = item[1];
                losersAndCountDict[player]++;
            }

            var zeroLosses = new List<int>();
            var oneLoss = new List<int>();

            foreach (var kvp in losersAndCountDict)
            {
                if (kvp.Value == 0)
                    zeroLosses.Add(kvp.Key);
                if (kvp.Value == 1)
                    oneLoss.Add(kvp.Key);
            }

            zeroLosses.Sort();
            oneLoss.Sort();

            return new List<IList<int>>()
            {
                new List<int>(zeroLosses),
                new List<int>(oneLoss)
            };
        }
    }
}
