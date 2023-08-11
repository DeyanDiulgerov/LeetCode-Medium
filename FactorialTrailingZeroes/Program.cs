using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialTrailingZeroes(13));
            Console.WriteLine(FactorialTrailingZeroes(7));
            Console.WriteLine(FactorialTrailingZeroes(9551));
            Console.WriteLine(FactorialTrailingZeroes(30));
            Console.WriteLine(FactorialTrailingZeroes(3));
            Console.WriteLine(FactorialTrailingZeroes(5));
            Console.WriteLine(FactorialTrailingZeroes(6));
            Console.WriteLine(FactorialTrailingZeroes(0));
        }

        public static int FactorialTrailingZeroes(int n)
        {
            var count = 0;
            for (var i = 5; i <= n; i *= 5)
                count += n / i;

            return count;
        }
    }
}
