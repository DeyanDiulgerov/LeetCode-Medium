using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagOfTokens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BagOfTokensScore(new int[] { 91, 4, 75, 70, 66, 71, 91, 64, 37, 54 }, 20));
            Console.WriteLine(BagOfTokensScore(new int[] { 100 }, 50));
            Console.WriteLine(BagOfTokensScore(new int[] { 200, 100 }, 150));
            Console.WriteLine(BagOfTokensScore(new int[] { 100, 200, 300, 400 }, 200));
        }
        public static int BagOfTokensScore(int[] tokens, int power)
        {
            List<int> listed = new List<int>(tokens);
            int score = 0;
            while (listed.Count() > 0)
            {
                int min = listed.Min();
                int max = listed.Max();
                if (listed.Count() == 1 && power < min)
                    break;
                if (power >= min)
                {
                    power -= min;
                    score++;
                    listed.Remove(min);
                }
                else if (power < min && score > 0)
                {
                    if (score >= 1)
                    {
                        power += max;
                        score--;
                        listed.Remove(max);
                    }
                }
                else
                    break;
            }
            return score;
        }
    }
}
