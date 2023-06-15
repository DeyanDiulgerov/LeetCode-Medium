using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateParentheses
{
     static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(String.Join(",", GenerateParenthesis(3)));
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(String.Join(",", GenerateParenthesis(1)));
            Console.WriteLine("---------------------------------------");
        }

        public static IList<string> GenerateParenthesis(int n)
        {
            var list = new List<string>();
            Gen(0, 0, "");
            return list;

            void Gen(int i, int j, string curr)
            {
                if(i >= n && j >= n)
                {
                    list.Add(curr);
                    return;
                }

                if (j < i)
                    Gen(i, j + 1, $"{curr})");
                if (i < n)
                    Gen(i + 1, j, $"{curr}(");
            }
        }
}
