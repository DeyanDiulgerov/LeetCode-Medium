using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HIndex(new int[] { 3, 0, 6, 1, 5 }));
            Console.WriteLine(HIndex(new int[] { 1, 3, 1 }));
        }
        public static int HIndex(int[] citations)
        {
            int n = citations.Length;

            while (n > 0)
            {
                int count = citations.Count(x => x >= n);
                if (count >= n)
                    return n;
                else
                    n--;
            }
            return n;
        }
    }
}
