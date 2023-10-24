using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovingStarsFromAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemovingStarsFromAString("leet**cod*e"));
            Console.WriteLine(RemovingStarsFromAString("erase*****"));
            Console.WriteLine(RemovingStarsFromAString("l*e*et**co*d*e"));
        }
        public static string RemovingStarsFromAString(string s)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                    stack.Pop();
                else
                    stack.Push(s[i]);
            }

            return String.Concat(stack.Reverse());
        }
    }
}
