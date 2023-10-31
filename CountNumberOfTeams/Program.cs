using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumberOfTeams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountNumberOfTeams(new int[] { 2, 5, 3, 4, 1 }));
            Console.WriteLine(CountNumberOfTeams(new int[] { 2, 1, 3 }));
            Console.WriteLine(CountNumberOfTeams(new int[] { 1, 2, 3, 4 }));
        }

        public static int CountNumberOfTeams(int[] rating)
        {
            int counter = 0;

            for (int i = 0; i < rating.Length; i++)
            {
                for (int j = i + 1; j < rating.Length; j++)
                {
                    for (int k = j + 1; k < rating.Length; k++)
                    {
                        if ((rating[i] < rating[j] && rating[j] < rating[k] && rating[i] < rating[k])
                         || (rating[i] > rating[j] && rating[j] > rating[k] && rating[i] > rating[k]))
                            counter++;
                    }
                }
            }
            return counter;
        }
    }
}
