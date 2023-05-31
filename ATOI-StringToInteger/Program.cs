using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOI_StringToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyAtoi("  -42"));
            Console.WriteLine(MyAtoi("00000-42a1234"));
            Console.WriteLine(MyAtoi("21474836460"));
            Console.WriteLine(MyAtoi("+"));
            Console.WriteLine(MyAtoi("-+12"));
            Console.WriteLine(MyAtoi("+-12"));
            Console.WriteLine(MyAtoi("words and 987"));
            Console.WriteLine(MyAtoi("42"));
            Console.WriteLine(MyAtoi("4193 with words"));
        }



        public static int MyAtoi(string s)
        {
            List<char> chars = new List<char>();
            s = s.TrimStart(' ');
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    chars.Add(s[i]);
                    continue;
                }
                if (i == 0 && s[0] == '-')
                    continue;
                if (i == 0 && s[0] == '+')
                    continue;
                break;
            }
            if (chars.Count == 0)
                return 0;

            // int.TryParse:
            // IF True it gives INTEGER result
            // IF False it gives MIN/MAX INT value;
            bool cor = int.TryParse(String.Join("", chars), out int result);
            if (cor && s[0] == '-')
                return -result;
            if (cor)
                return result;
            if (!cor && s[0] == '-')
                return int.MinValue;
            else
                return int.MaxValue;

        }
    }
}
