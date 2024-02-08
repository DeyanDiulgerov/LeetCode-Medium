using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PerfectSquares(22));
            Console.WriteLine(PerfectSquares(67));
            Console.WriteLine(PerfectSquares(43));
            Console.WriteLine(PerfectSquares(4));
            Console.WriteLine(PerfectSquares(12));
            Console.WriteLine(PerfectSquares(13));
            Console.WriteLine(PerfectSquares(25));
            Console.WriteLine(PerfectSquares(37));
            Console.WriteLine(PerfectSquares(95));
            Console.WriteLine(PerfectSquares(214));
            Console.WriteLine(PerfectSquares(536));
            Console.WriteLine(PerfectSquares(1754));
        }
        public static int PerfectSquares(int n)
        {
            if (n <= 3)
                return n;
            List<int> allSquares = new List<int>();
            for (int i = 1; i < 10000; i++)
            {
                if (i * i > n)
                    break;
                allSquares.Add(i * i);
            }
            Console.WriteLine(String.Join(",", allSquares));

            int permaN = n;
            int counter = 0;
            int min = int.MaxValue;
            bool firstNum = true;
            while (n > 0 && allSquares.Count() > 1)
            {
                for (int i = allSquares.Count() - 1; i >= 0; i--)
                {
                    if (allSquares[i] <= n && firstNum == true)
                    {
                        firstNum = false;
                        n -= allSquares[i];
                        counter++;
                        break;
                    }
                    else if (firstNum == false)
                    {
                        if (allSquares[i] <= n && n % allSquares[i] == 0 || allSquares.Contains(n - allSquares[i]))
                        {
                            n -= allSquares[i];
                            counter++;
                            break;
                        }
                    }
                }

                if (n <= 0)
                {
                    min = Math.Min(min, counter);
                    allSquares.Remove(allSquares.Last());
                    n = permaN;
                    counter = 0;
                    firstNum = true;
                }
            }
            return min;
        }
    }
}
