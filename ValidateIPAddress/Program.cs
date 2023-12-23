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
             Console.WriteLine(ValidIPAddress("1e1.4.5.6"));
            Console.WriteLine(ValidIPAddress("172.16.254.1"));
            Console.WriteLine(ValidIPAddress("2001:0db8:85a3:0:0:8A2E:0370:7334"));
            // TEST IPv4 Addresses:
            Console.WriteLine(ValidIPAddress("256.256.256.256"));// INVALID
            Console.WriteLine(ValidIPAddress("192.168.1.1"));// VALID
            Console.WriteLine(ValidIPAddress("192.168.1.0"));// VALID
            Console.WriteLine(ValidIPAddress("192.168.01.1"));// INVALID
            Console.WriteLine(ValidIPAddress("192.168.1.00"));// INVALID
            // TEST IPv6 Addresses:
            Console.WriteLine(ValidIPAddress
                ("2001:0db8:85a3:0000:0000:8a2e:0370:7334"));// VALID
            Console.WriteLine(ValidIPAddress
                ("2001:db8:85a3:0:0:8A2E:0370:7334"));// VALID
            Console.WriteLine(ValidIPAddress
                ("2001:0db8:85a3::8A2E:037j:7334"));// INVALID
            Console.WriteLine(ValidIPAddress
                ("02001:0db8:85a3:0000:0000:8a2e:0370:7334"));// INVALID
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
