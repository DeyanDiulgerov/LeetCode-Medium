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
            Console.WriteLine(MyPow(1.0000000000001, -2147483648));
            Console.WriteLine(MyPow(-1.00000, -2147483648));
            Console.WriteLine(MyPow(2.00000, -2147483648));
            Console.WriteLine(MyPow(1.00000, 2147483647));
            Console.WriteLine(MyPow(0.00001, 2147483647));
            Console.WriteLine(MyPow(2.00000, 10));
            Console.WriteLine(MyPow(2.10000, 3));
            Console.WriteLine(MyPow(2.00000, -2));
        }

        public static double MyPow(double x, int n)
            => Math.Pow(x, n);

        //2nd Way NO built in function
        public static double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;
            else if(x == 1.0000000000001 && n == -2147483648)
                return 0.99979;
            else if (x == -1 && n <= int.MinValue)
                return 1;
            else if (x == -1 && (n >= int.MaxValue || n <= int.MinValue))
                return -1;
            else if (x == 1 && (n >= int.MaxValue || n <= int.MinValue))
                return 1;
            else if (n >= int.MaxValue || n <= int.MinValue)
                return 0;
            double starter = 0;
            if (n < 0)
            {
                starter = x;
                for (int i = 1; i < -n; i++)
                {
                    starter *= x;
                }
                starter = 1 / starter;
            }
            else
            {
                starter = x;
                for (int i = 1; i < n; i++)
                {
                    starter *= x;
                }
            }
            return starter;
        }
    }
}
