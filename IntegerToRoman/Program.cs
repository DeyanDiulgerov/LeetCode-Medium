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
            Console.WriteLine(IntegerToRoman(20));
            Console.WriteLine(IntegerToRoman(3));
            Console.WriteLine(IntegerToRoman(58));
            Console.WriteLine(IntegerToRoman(1994));
            Console.WriteLine(IntToRomanMap(20));
            Console.WriteLine(IntToRomanMap(3));
            Console.WriteLine(IntToRomanMap(58));
            Console.WriteLine(IntToRomanMap(1994));
        }
        public static string IntToRomanMap(int num)
        {
            var numToRomanMap = new Dictionary<int, string>()
            {
                {1, "I"},
                {4, "IV"},
                {5, "V"},
                {9, "IX"},
                {10, "X"},
                {40, "XL"},
                {50, "L"},
                {90, "XC"},
                {100, "C"},
                {400, "CD"},
                {500, "D"},
                {900, "CM"},
                {1000, "M"},
            };

            /* numToRomanMap = numToRomanMap
                 .OrderByDescending(x => x.Key)
                 .ToDictionary(x => x.Key, x => x.Value);*/

            var result = "";
            while (num > 0)
            {
                foreach (var kvp in numToRomanMap.OrderByDescending(x => x.Key))
                {
                    if (num >= kvp.Key)
                    {
                        result += kvp.Value;
                        num -= kvp.Key;
                        break;
                    }
                    if (num <= 0)
                        break;
                }
            }
            return result;
        }
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
