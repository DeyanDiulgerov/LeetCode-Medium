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
            // IPv4
            if (queryIP.Contains("."))
            {
                string[] splitted = queryIP.Split('.');
                if (splitted.Length != 4)
                    return "Neither";

                for (int i = 0; i < splitted.Length; i++)
                {
                    if (splitted[i].Length > 3)
                        return "Neither";
                   if (splitted[i].Any(x => char.IsLetter(x)) || splitted[i].Length == 0)
                        return "Neither";
                    int currNum = int.Parse(splitted[i]);
                    if (currNum < 0 || currNum > 255)
                        return "Neither";
                    if (currNum.ToString() != splitted[i])
                        return "Neither";
                }
                return "IPv4";
            }
            // IPv6
            else if(queryIP.Contains(":"))
            {
                string[] splitted = queryIP.Split(':');
                var allowedChars = new List<char>()
                {'a', 'b', 'c', 'd', 'e', 'f', 'A', 'B', 'C', 'D', 'E', 'F', };

                if (splitted.Length != 8)
                    return "Neither";
                for (int i = 0; i < splitted.Length; i++)
                {
                    if (splitted[i].Length < 1 || splitted[i].Length > 4)
                        return "Neither";
                    if (splitted[i].Any(x => char.IsLetter(x) && !allowedChars.Contains(x)))
                        return "Neither";
                }
                return "IPv6";
            }
            return "Neither";
        }
    }
}
