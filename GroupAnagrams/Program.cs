using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
            var input2 = GroupAnagrams(new string[] { "", "" });
            var input3 = GroupAnagrams(new string[] { "a" });
            var input4 = GroupAnagrams(new string[] { "c", "c" });

            foreach (var item in input1)
                Console.WriteLine(String.Join(",", item));

            foreach (var item in input2)
                Console.WriteLine(String.Join(",", item));

            foreach (var item in input3)
                Console.WriteLine(String.Join(",", item));

            foreach (var item in input4)
                Console.WriteLine(String.Join(",", item));
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dictAnagramAndAllWords = new Dictionary<string, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] arr = strs[i].ToCharArray();
                Array.Sort(arr);
                var sortedWord = new string(arr);

                if (!dictAnagramAndAllWords.ContainsKey(sortedWord))
                    dictAnagramAndAllWords.Add(sortedWord, new List<string>() { strs[i] });
                else
                    dictAnagramAndAllWords[sortedWord].Add(strs[i]);
            }

            var result = dictAnagramAndAllWords.Values.ToList();
            return result;
        }
    }
}
