using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchSuggestionsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in SearchSuggestionsSystem(
                new string[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" }, "mouse"))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in SearchSuggestionsSystem(
               new string[] { "havana" }, "havana"))
                Console.WriteLine(String.Join(",", item));
        }

        public static IList<IList<string>> SearchSuggestionsSystem(string[] products, string searchWord)
        {
            var result = new List<IList<string>>();
            var listedProd = products.OrderBy(x => x, StringComparer.Ordinal).ToList();
            int n = listedProd.Count();
            string prefix = "";

            for (int i = 0; i < searchWord.Length; i++)
            {
                prefix += searchWord[i];
                var newList = new List<string>();

                for (int j = 0; j < n; j++)
                {
                    if (listedProd[j].StartsWith(prefix))
                        newList.Add(listedProd[j]);

                }
                newList = newList.Take(3).ToList();
                result.Add(newList);
            }
            return result;
        }
    }
}
