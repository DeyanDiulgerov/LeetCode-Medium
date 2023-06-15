using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle1 = Generate(1);
            var triangle2 = Generate(2);
            var triangle3 = Generate(3);
            var triangle4 = Generate(4);
            var triangle5 = Generate(5);

            foreach (var item in triangle1)
                Console.Write($"[{String.Join(",", item)}]");
            Console.WriteLine("\n----------------------------------");

            foreach (var item in triangle2)
                Console.Write($"[{String.Join(",", item)}]");
            Console.WriteLine("\n----------------------------------");

            foreach (var item in triangle3)
                Console.Write($"[{String.Join(",", item)}]");
            Console.WriteLine("\n----------------------------------");

            foreach (var item in triangle4)
                Console.Write($"[{String.Join(",", item)}]");
            Console.WriteLine("\n----------------------------------");

            foreach (var item in triangle5)
                Console.Write($"[{String.Join(",", item)}]");
            Console.WriteLine("\n----------------------------------");
        }

        public static IList<IList<int>> Generate(int numRows)
        {
            var triangle = new List<IList<int>>();

            if (numRows == 0) return triangle;
            triangle.Add(new List<int>(1) { 1 });
            if (numRows == 1) return triangle;
            triangle.Add(new List<int>(2) { 1, 1 });
            if (numRows == 2) return triangle;

            for (int i = 2; i < numRows; i++)
            {
                var newList = new List<int>();
                newList.Add(1);

                for (int j = 1; j < i; j++)
                {
                    int number = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    newList.Add(number);
                }

                newList.Add(1);
                triangle.Add(newList);
            }

            return triangle;
        }
    }
}
