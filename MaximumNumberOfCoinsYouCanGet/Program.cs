using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberOfCoinsYouCanGet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumNumberOfCoinsYouCanGet(new int[] { 8, 62, 95, 59, 68, 92, 31, 85, 48, 100, 23, 37, 11, 86, 41, 43, 93, 58, 54, 66, 21, 12, 6, 37 }));
            Console.WriteLine(MaximumNumberOfCoinsYouCanGet(new int[] { 4, 4, 17, 7, 16, 16, 16, 15, 2, 3, 1, 17, 6, 12, 9 }));
            Console.WriteLine(MaximumNumberOfCoinsYouCanGet(new int[] { 2, 4, 1, 2, 7, 8 }));
            Console.WriteLine(MaximumNumberOfCoinsYouCanGet(new int[] { 2, 4, 5 }));
            Console.WriteLine(MaximumNumberOfCoinsYouCanGet(new int[] { 9, 8, 7, 6, 5, 1, 2, 3, 4 }));
        }


        public static int MaximumNumberOfCoinsYouCanGet(int[] piles)
        {
            int n = piles.Length / 3;
            var listedPiles = new List<int>(piles);
            int maxCoins = 0;

            listedPiles.Sort();
            listedPiles.Reverse();

            int counter = 1;

            for (int i = 0; i < n; i++)
            {
                maxCoins += listedPiles[counter];
                counter += 2;
            }

            return maxCoins;
        }
    }
}
