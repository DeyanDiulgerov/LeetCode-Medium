using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyPow(2.00000, 10));
            Console.WriteLine(MyPow(2.10000, 3));
            Console.WriteLine(MyPow(2.00000, -2));
        }

        public static double MyPow(double x, int n)
            => Math.Pow(x, n);
    }
}
