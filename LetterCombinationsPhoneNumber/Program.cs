using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCombinationsPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", LetterCombinations("23")));
            Console.WriteLine(String.Join(",", LetterCombinations("")));
            Console.WriteLine(String.Join(",", LetterCombinations("2")));
        }

        public static IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();

            if (string.IsNullOrEmpty(digits)) return result;

            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
            { "2", "abc" },
            { "3", "def" },
            { "4", "ghi" },
            { "5", "jkl" },
            { "6", "mno" },
            { "7", "qprs" },
            { "8", "tuv" },
            { "9", "wxyz" }
            };

            void Backtracking(int index, string curr)
            {
                if (curr.Length == digits.Length)
                {
                    result.Add(curr);
                    return;
                }

                string chars = dict[digits[index].ToString()];
                for (int i = 0; i < chars.Length; i++)
                {
                    Backtracking(index + 1, curr + chars[i]);
                }
            }

            Backtracking(0, string.Empty);

            return result;
        }
    }
}
