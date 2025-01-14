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
            var setA = new HashSet<int>();
            var setB = new HashSet<int>();
            int length = A.Length;
            int[] res = new int[length];
            int count = 0;
            for(int i = 0; i < length; i++)
            {
                setA.Add(A[i]);
                setB.Add(B[i]);
                res[i] = setA.Count(x => setB.Contains(x));
            }
            return res;
        }
    }
}
