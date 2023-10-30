using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumMatchingOfPlayersWithTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumMatchingOfPlayersWithTrainers(
                new int[] { 1, 1000000000 },
                new int[] { 1000000000, 1 }));
            Console.WriteLine(MaximumMatchingOfPlayersWithTrainers(new int[] { 4, 7, 9 }, new int[] { 8, 2, 5, 8 }));
            Console.WriteLine(MaximumMatchingOfPlayersWithTrainers(new int[] { 1, 1, 1 }, new int[] { 10 }));
        }

        public static int MaximumMatchingOfPlayersWithTrainers(int[] players, int[] trainers)
        {
            var listedTrainers = new List<int>(trainers);
            listedTrainers.Sort();
            Array.Sort(players);
            int counter = 0;

            for (int i = 0; i < players.Length; i++)
            {
                if (listedTrainers.Count() == 0)
                    break;

                var coach = listedTrainers.FirstOrDefault(x => x >= players[i]);
                if (coach != 0)
                {
                    listedTrainers.Remove(coach);
                    counter++;
                }
            }

            return counter;
        }
    }
}
