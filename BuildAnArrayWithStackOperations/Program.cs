using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAnArrayWithStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", BuildAnArrayWithStackOperations(new int[] { 1, 3, 4, 6, 7, 8 }, 9)));
            Console.WriteLine(String.Join(",", BuildAnArrayWithStackOperations(new int[] { 1, 3 }, 3)));
            Console.WriteLine(String.Join(",", BuildAnArrayWithStackOperations(new int[] { 1, 2, 3 }, 3)));
            Console.WriteLine(String.Join(",", BuildAnArrayWithStackOperations(new int[] { 1, 2 }, 4)));
        }

        public static IList<string> BuildAnArrayWithStackOperations(int[] target, int n)
        {
            int m = target.Length;
            var resultList = new List<string>();
            var testList = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (target.Contains(i))
                {
                    resultList.Add("Push");
                    testList.Add(i);
                }
                else
                {
                    resultList.Add("Push");
                    resultList.Add("Pop");
                }
                if (testList.SequenceEqual(target))
                    break;
            }
            return resultList;
        }
    }
}
