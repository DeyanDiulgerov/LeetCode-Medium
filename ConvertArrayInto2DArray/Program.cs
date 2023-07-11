using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertArrayInto2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = ConvertArrayInto2DArray(new int[] { 1, 3, 4, 1, 2, 3, 1 });
            var matrix2 = ConvertArrayInto2DArray(new int[] { 1, 2, 3, 4 });

            foreach (var item in matrix1)
                Console.Write($"[{String.Join(",", item)}]");

            Console.WriteLine($"\n------------------------------");

            foreach (var item in matrix2)
                Console.Write($"[{String.Join(",", item)}]");

            Console.WriteLine($"\n------------------------------");
        }

        public static IList<IList<int>> ConvertArrayInto2DArray(int[] nums)
        {
            var result = new List<IList<int>>();
            var listedNums = new List<int>(nums);

            while (listedNums.Count() > 0)
            {
                var distinct = listedNums.Distinct();
                var newList = new List<int>(distinct);
                result.Add(newList);

                foreach (var item in distinct.ToList())
                    listedNums.Remove(item);
            }

            return result;
        }
    }
}
