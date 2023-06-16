using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(-2147483648, -1));
            Console.WriteLine(Divide(10, 3));
            Console.WriteLine(Divide(7, 3));
            Console.WriteLine(Divide(7, -3));
        }

        public static int Divide(int dividend, int divisor)
        {
            long longDividend = dividend;
            long longDivisor = divisor;

            long result = longDividend / longDivisor;

            double test = (double)result;

            if (test > int.MaxValue)
                return int.MaxValue;
            else if (test < int.MinValue)
                return int.MinValue;

            return (int)Math.Floor(test);
        }
    }
}
