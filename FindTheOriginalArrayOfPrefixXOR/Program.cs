using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheOriginalArrayOfPrefixXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindTheOriginalArrayOfPrefixXOR(new int[] { 5, 2, 0, 3, 1 })));
            Console.WriteLine(String.Join(",", FindTheOriginalArrayOfPrefixXOR(new int[] { 13 })));
        }

        public static int[] FindTheOriginalArrayOfPrefixXOR(int[] pref)
        {
            int n = pref.Length;
            var result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    int num = pref[i];
                    result.Add(num);
                }
                if (i < n - 1)
                {
                    int num = pref[i] ^ pref[i + 1];
                    result.Add(num);
                }
            }

            return result.ToArray();
        }
    }
}
