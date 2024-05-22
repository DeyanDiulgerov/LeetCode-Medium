using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToRoman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IntegerToRoman == many if check - better performane but uglier code
            // IntegerToRomanMap == using HashMap - poorer performance
            Console.WriteLine(IntegerToRoman(20));
            Console.WriteLine(IntegerToRoman(3));
            Console.WriteLine(IntegerToRoman(58));
            Console.WriteLine(IntegerToRoman(1994));
            Console.WriteLine(IntToRomanMap(20));
            Console.WriteLine(IntToRomanMap(3));
            Console.WriteLine(IntToRomanMap(58));
            Console.WriteLine(IntToRomanMap(1994));
        }
        //Using Map - poorer performance
        public static string IntToRomanMap(int num)
        {
            var map = new Dictionary<string, int>()
            {
                {"M", 1000},
                {"CM", 900},
                {"D", 500},
                {"CD", 400},
                {"C", 100},
                {"XC", 90},
                {"L", 50},
                {"XL", 40},
                {"X", 10},
                {"IX", 9},
                {"V", 5},
                {"IV", 4},
                {"I", 1},
            };
            StringBuilder sb = new StringBuilder();
            while(num > 0)
            {
                foreach(var kvp in map)
                {
                    if(num >= kvp.Value)
                    {
                        num -= kvp.Value;
                        sb.Append(kvp.Key);
                        break;
                    }
                }
            }
            return sb.ToString();
        }
        // Many if checks - better performace - uglier code
        public static string IntegerToRoman(int num)
        {
            var result = "";

            while (num > 0)
            {
                if (num >= 1000)
                {
                    result += "M";
                    num -= 1000;
                }
                else if (num >= 900)
                {
                    result += "CM";
                    num -= 900;
                }
                else if (num >= 500)
                {
                    result += "D";
                    num -= 500;
                }
                else if (num >= 400)
                {
                    result += "CD";
                    num -= 400;
                }
                else if (num >= 100)
                {
                    result += "C";
                    num -= 100;
                }
                else if (num >= 90)
                {
                    result += "XC";
                    num -= 90;
                }
                else if (num >= 50)
                {
                    result += "L";
                    num -= 50;
                }
                else if (num >= 40)
                {
                    result += "XL";
                    num -= 40;
                }
                else if (num >= 10)
                {
                    result += "X";
                    num -= 10;
                }
                else if (num >= 9)
                {
                    result += "IX";
                    num -= 9;
                }
                else if (num >= 5)
                {
                    result += "V";
                    num -= 5;
                }
                else if (num >= 4)
                {
                    result += "IV";
                    num -= 4;
                }
                else if (num >= 1)
                {
                    result += "I";
                    num -= 1;
                }
            }
            return result;
        }
    }
}
