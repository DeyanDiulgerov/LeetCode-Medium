using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPrimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountPrimes(10));
            Console.WriteLine(CountPrimes(0));
            Console.WriteLine(CountPrimes(1));
            Console.WriteLine(CountPrimes(7));
            Console.WriteLine(CountPrimes(43924));
        }

        public static int CountPrimes(int n)
        {
            if (n <= 2)
                return 0;

            int result = 0;
            bool[] sieve = new bool[n + 1];

            for (int i = 2; i < n; i++)
            {
                if (sieve[i])
                    continue;

                result++;
                int count = 2;

                while (i * count < n)
                {
                    sieve[i * count] = true;
                    count++;
                }
            }
            return result;
        }
    }
}
