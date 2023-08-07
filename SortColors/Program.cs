using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SortColors(new int[] { 2, 0, 2, 1, 1, 0 })));
            Console.WriteLine(String.Join(",", SortColors(new int[] { 2, 0, 1 })));
        }

        public static int[] SortColors(int[] nums)
        {
            var zeroesCount = nums.Where(x => x == 0).Count();
            var onesCount = nums.Where(x => x == 1).Count();
            var twosCount = nums.Where(x => x == 2).Count();
            var resultList = new List<int>();

            for (int i = 0; i < zeroesCount; i++)
                resultList.Add(0);
            for (int i = 0; i < onesCount; i++)
                resultList.Add(1);
            for (int i = 0; i < twosCount; i++)
                resultList.Add(2);

            return resultList.ToArray();
        }
    }
}
