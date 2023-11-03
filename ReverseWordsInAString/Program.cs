using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWordsInAString("the sky is blue"));
            Console.WriteLine(ReverseWordsInAString("  hello world  "));
            Console.WriteLine(ReverseWordsInAString("a good   example"));
        }

        public static string ReverseWordsInAString(string s)
        {
            s = s.Trim(' ');
            var splitted = s.Split(' ').ToList();
            splitted.RemoveAll(x => x == "");

            int left = 0, right = splitted.Count() - 1;
            while (left < right)
            {
                var tempLeft = splitted[left];
                splitted[left] = splitted[right];
                splitted[right] = tempLeft;

                left++;
                right--;
            }
            return String.Join(" ", splitted);
        }
    }
}
