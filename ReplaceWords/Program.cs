using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceWords(new List<string>() { "cat", "bat", "rat" },
                "the cattle was rattled by the battery"));
            Console.WriteLine(ReplaceWords(new List<string>() { "a", "b", "c" },
                "aadsfasf absbs bbab cadsfafs"));
        }

        public static string ReplaceWords(IList<string> dictionary, string sentence)
        {
            dictionary = dictionary.OrderBy(x => x.Length).ToList();
            string[] splitted = sentence.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string word in splitted)
            {
                if(dictionary.Any(x => word.StartsWith(x)) == true)
                    sb.Append(dictionary.First(x => word.StartsWith(x)) + " ");
                else
                    sb.Append(word + " ");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
