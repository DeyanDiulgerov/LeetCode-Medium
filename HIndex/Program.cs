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
            int h = citations.Length + 1;
            while(h-- > 0)
                if(citations.Count(x => x >= h) >= h)
                    break;
            return h;
        }
    }
}
