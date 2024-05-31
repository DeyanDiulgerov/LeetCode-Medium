using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintWordsVertically
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", PrintWordsVertically("HOW ARE YOU")));
            Console.WriteLine(String.Join(",", PrintWordsVertically("TO BE OR NOT TO BE")));
            Console.WriteLine(String.Join(",", PrintWordsVertically("CONTEST IS COMING")));
        }
        public static IList<string> PrintWordsVertically(string s)
        {
            string[] splitted = s.Split(' ');
            int longest = splitted.OrderBy(x => x.Length).Last().Length;
            string[] result = new string[longest];
            int counter = 0;
            while (counter < longest)
            {
                string newRes = "";
                for (int i = 0; i < splitted.Count(); i++)
                {
                    if (counter >= splitted[i].Length)
                        newRes += " ";
                    else
                        newRes += splitted[i][counter];
                }
                result[counter] = newRes.TrimEnd(' ');
                counter++;
            }
            return result.ToList();
        }
    }
}
