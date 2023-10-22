using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateIPAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidateIPAddress("20EE:FGb8:85a3:0:0:8A2E:0370:7334"));
            Console.WriteLine(ValidateIPAddress("12.12.12.12.12"));
            Console.WriteLine(ValidateIPAddress("1.1.1.1."));
            Console.WriteLine(ValidateIPAddress("172.16.254.1"));
            Console.WriteLine(ValidateIPAddress("2001:0db8:85a3:0:0:8A2E:0370:7334"));
            Console.WriteLine(ValidateIPAddress("256.256.256.256"));
        }

        public static string ValidateIPAddress(string queryIP)
        {
            if (queryIP.Contains('.'))
            {
                var splitted = queryIP.Split('.');
                if (splitted.Length != 4)
                    return "Neither";

                for (int i = 0; i < splitted.Length; i++)
                {
                    if (splitted[i] == "")
                        return "Neither";
                    if (!splitted[i].All(x => char.IsDigit(x)))
                        return "Neither";
                    if (splitted[i].Length > 9)
                        return "Neither";
                    if (int.Parse(splitted[i]) > 255)
                        return "Neither";
                    if (splitted[i].Length > 1 && splitted[i][0] == '0')
                        return "Neither";
                }

                return "IPv4";
            }
            else
            {
                var splitted = queryIP.Split(':');
                if (splitted.Length != 8)
                    return "Neither";

                var hexadecimalChars = new List<char>()
                {'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F' };

                for (int i = 0; i < splitted.Length; i++)
                {
                    if (splitted[i].Length < 1 || splitted[i].Length > 4)
                        return "Neither";

                    for (int j = 0; j < splitted[i].Length; j++)
                    {
                        if (char.IsLetter(splitted[i][j]) && !hexadecimalChars.Contains(splitted[i][j]))
                            return "Neither";
                    }
                }

                return "IPv6";
            }
        }
    }
}
