using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheWinnerOfTheCircularGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheWinnerOfTheCircularGame(5, 2));
            Console.WriteLine(FindTheWinnerOfTheCircularGame(6, 5));
        }

        public static int FindTheWinnerOfTheCircularGame(int n, int k)
        {   
             // first circle from 1 to n == 1 to 5
            // Use Queue to circle around from 5 to 1
            
            var queue = new Queue<int>();
            for (int i = 1; i <= n; i++)
                queue.Enqueue(i);

            int counter = k;

            while (queue.Count() > 1)
            {
                int player = queue.Dequeue();

                if (--counter > 0)
                {
                    queue.Enqueue(player);
                }
                else
                {
                    counter = k;
                }
            }

            return queue.Dequeue();
        }
    }
}
