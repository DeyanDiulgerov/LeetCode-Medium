using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniquePaths(3, 7));
            Console.WriteLine(UniquePaths(3, 2));
        }

        public static int UniquePaths(int m, int n)
        {
            long result = 1;
            for (int i = 1; i < m; i++)
            {
                result *= n + i - 1;
                result /= i;
            }
            return (int)result;
        }
    }
}
