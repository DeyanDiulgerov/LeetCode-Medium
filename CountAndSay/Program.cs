using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountAndSay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountAndSay(1));
            Console.WriteLine(CountAndSay(2));
            Console.WriteLine(CountAndSay(3));
            Console.WriteLine(CountAndSay(4));
            Console.WriteLine(CountAndSay(5));
        }

        public static string CountAndSay(int n)
        {
            if (n == 1)
                return "1";

            return Say(CountAndSay(n - 1));

            string Say(string s)
            {
                int length = s.Length;
                var result = new StringBuilder();
                int counter = 0;
                for (int i = 0; i < length - 1; i++)
                {
                    counter++;

                    if (s[i] != s[i + 1])
                    {
                        result.Append(counter.ToString());
                        result.Append(s[i].ToString());
                        counter = 0;
                    }
                }
                counter++;
                result.Append(counter.ToString());
                result.Append(s[length - 1].ToString());
                return result.ToString();
            }
        }
    }
}
