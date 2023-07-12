using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThePrefixCommonArrayOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindThePrefixCommonArrayOfTwoArrays
                (new int[] { 1, 3, 2, 4 }, new int[] { 3, 1, 2, 4 })));

            Console.WriteLine(String.Join(",", FindThePrefixCommonArrayOfTwoArrays
               (new int[] { 2, 3, 1 }, new int[] { 3, 1, 2 })));
        }

        public static int[] FindThePrefixCommonArrayOfTwoArrays(int[] A, int[] B)
        {
            int n = A.Length;
            var aList = new List<int>(A);
            var bList = new List<int>(B);
            var result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int counter = 0;
                var testAList = new List<int>();
                var testBList = new List<int>();

                for (int a = i; a >= 0; a--)
                    testAList.Add(A[a]);
                for (int b = i; b >= 0; b--)
                    testBList.Add(B[b]);

                foreach (var item in testAList)
                {
                    if (testBList.Contains(item))
                        counter++;
                }

                result.Add(counter);
            }

            return result.ToArray();
        }
    }
}
