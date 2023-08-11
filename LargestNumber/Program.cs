using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestNumber(new int[] { 10, 2 }));
            Console.WriteLine(LargestNumber(new int[] { 3, 30, 34, 5, 9 }));
        }

        public static string LargestNumber(int[] nums)
        {
            return string.Join("", nums.Select(x => x.ToString())
                        .OrderBy(s => s,
                        Comparer<string>.Create((x, y) => string.Compare(y + x, x + y))))
                     .TrimStart('0')
                     .PadLeft(1, '0');
        }
    }
}
