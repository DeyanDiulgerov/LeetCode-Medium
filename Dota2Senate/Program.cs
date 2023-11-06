using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2Senate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dota2Senate("DDRRR"));
            Console.WriteLine(Dota2Senate("R"));
            Console.WriteLine(Dota2Senate("RRD"));
            Console.WriteLine(Dota2Senate("RRR"));
            Console.WriteLine(Dota2Senate("DDR"));
            Console.WriteLine(Dota2Senate("D"));
            Console.WriteLine(Dota2Senate("RD"));
            Console.WriteLine(Dota2Senate("RDD"));
        }

        public static string Dota2Senate(string senate)
        {
            var senators = new Queue<char>(senate);
            var rCount = senate.Count(x => x == 'R');
            var dCount = senate.Length - rCount;
            int scale = 0;

            while (rCount > 0 && dCount > 0)
            {
                var curr = senators.Dequeue();

                if (curr == 'R')
                {
                    if (scale >= 0)
                    {
                        dCount--;
                        senators.Enqueue(curr);
                    }
                    scale++;
                }
                else
                {
                    if (scale <= 0)
                    {
                        rCount--;
                        senators.Enqueue(curr);
                    }
                    scale--;
                }
            }

            return rCount == 0 ? "Dire" : "Radiant";
        }
    }
}
