using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", ReverseInteger(-2147483648)));
            Console.WriteLine(String.Join(",", ReverseInteger(2147483647)));
            Console.WriteLine(String.Join(",", ReverseInteger(1534236469)));
            Console.WriteLine(String.Join("", ReverseInteger(123)));
            Console.WriteLine(String.Join(",", ReverseInteger(-123)));
            Console.WriteLine(String.Join(",", ReverseInteger(-2147483412)));
            Console.WriteLine(String.Join(",", ReverseInteger(901000)));
            Console.WriteLine(String.Join(",", ReverseInteger(120)));
            Console.WriteLine(String.Join(",", ReverseInteger(12000)));
            Console.WriteLine(String.Join(",", ReverseInteger(12022)));
        }

        public static int ReverseInteger(int x)
        {
            if (x == 0)
                return 0;

            var reversed = new List<string>();
            bool negative = false;
            var charX = x.ToString().ToCharArray();
            var listX = new List<char>(charX);

            for (int i = charX.Length - 1; i >= 0; i--)
            {
                if (i == 0 && listX[i] == '-')
                {
                    negative = true;
                }
                else
                    reversed.Add(charX[i].ToString());
            }
            var result = "";
            if (negative)
            {
                result += "-";
            }

            foreach (var item in reversed)
            {
                result += item;
            }
            var maxValue = 2147483647;
            long longedResult = long.Parse(result);

            if (longedResult >= 2147483647 || longedResult <= -2147483647)
                return 0;

            //int.Parse(result) REMOVES 0's if they are before the result == 00002324 == 2342 BUT 2053 = 3502
            return int.Parse(result);
        }
    }
}
