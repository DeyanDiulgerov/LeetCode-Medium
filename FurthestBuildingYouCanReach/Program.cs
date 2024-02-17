using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurthestBuildingYouCanReach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FurthestBuildingYouCanReach(new int[] { 1, 5, 1, 2, 3, 4, 10000 }, 4, 1));
            Console.WriteLine(FurthestBuildingYouCanReach(new int[] { 4, 2, 7, 6, 9, 14, 12 }, 5, 1));
            Console.WriteLine(FurthestBuildingYouCanReach(new int[] { 4, 12, 2, 7, 3, 18, 20, 3, 19 }, 10, 2));
            Console.WriteLine(FurthestBuildingYouCanReach(new int[] { 14, 3, 19, 3 }, 17, 0));
        }
        public static int FurthestBuildingYouCanReach(int[] heights, int bricks, int ladders)
        {
            List<int> allGaps = new List<int>();
            for (int i = 0; i < heights.Length - 1; i++)
            {
                int diff = heights[i + 1] - heights[i];
                if (diff > 0)
                {
                    bricks -= diff;
                    allGaps.Add(diff);
                    if (bricks < 0)
                    {
                        if (ladders == 0)
                            return i;
                        else
                        {
                            int max = allGaps.Max();
                            bricks += max;
                            ladders--;
                            allGaps.Remove(max);
                        }
                    }
                }
            }
            return heights.Length - 1;
        }
    }
}
