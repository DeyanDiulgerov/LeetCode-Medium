using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAllOccurrencesOfAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveAllOccurrencesOfAString("daabcbaabcbc", "abc"));
            Console.WriteLine(RemoveAllOccurrencesOfAString("axxxxyyyyb", "xy"));
        }
        public static string RemoveAllOccurrencesOfAString(string s, string part)
        {
            while (s.Contains(part))
            {
                var index = s.IndexOf(part);
                s = s.Remove(index, part.Length);
            }

            return s;
        }
    }
}
