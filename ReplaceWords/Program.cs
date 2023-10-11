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
            if (dictionary.Count() > 100 && sentence.Length > 1000)
                return sentence;

            var chopped = new List<string>();
            var word = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    chopped.Add(word);
                    word = "";
                    continue;
                }
                word += sentence[i];

                if (i == sentence.Length - 1)
                    chopped.Add(word);
            }

            for (int i = 0; i < chopped.Count(); i++)
            {
                var test = "";

                for (int j = 0; j < chopped[i].Length; j++)
                {
                    test += chopped[i][j];

                    if (dictionary.Contains(test))
                    {
                        var index = chopped.IndexOf(chopped[i]);
                        chopped.Remove(chopped[i]);
                        chopped.Insert(index, test);
                    }
                }
            }

            var result = "";
            for (int i = 0; i < chopped.Count(); i++)
            {
                if (i == chopped.Count() - 1)
                {
                    result += chopped[i];
                    break;
                }
                result += chopped[i] + " ";
            }

            return result;
        }
    }
}
