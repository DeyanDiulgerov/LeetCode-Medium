using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLengthOfTheLongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheLengthOfTheLongestCommonPrefix(new int[] { 17 }, new int[] { 16 }));
            Console.WriteLine(FindTheLengthOfTheLongestCommonPrefix(new int[] { 1, 10, 100 }, new int[] { 1000 }));
            Console.WriteLine(FindTheLengthOfTheLongestCommonPrefix(new int[] { 1, 2, 3 }, new int[] { 4, 4, 4 }));
        }
        public static int FindTheLengthOfTheLongestCommonPrefix(int[] arr1, int[] arr2)
        {
            int max = 0;
            var set = new HashSet<string>();
            for (int i = 0; i < arr1.Length; i++)
            {
                string word = arr1[i].ToString();
                string prefix = "";
                for (int j = 0; j < word.Length; j++)
                {
                    prefix += word[j];
                    set.Add(prefix);
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                string word = arr2[i].ToString();
                string prefix = "";
                for (int j = 0; j < word.Length; j++)
                {
                    prefix += word[j];
                    if (set.Contains(prefix))
                        max = Math.Max(max, prefix.Length);
                }
            }
            return max;
        }
    }
}
