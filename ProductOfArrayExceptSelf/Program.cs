using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOfArrayExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", ProductOfArrayExceptSelf(new int[] { 0, 0 })));
            Console.WriteLine(String.Join(",", ProductOfArrayExceptSelf(new int[] { 1, 2, 3, 4 })));
            Console.WriteLine(String.Join(",", ProductOfArrayExceptSelf(new int[] { -1, 1, 0, -3, 3 })));
        }

        public static int[] ProductOfArrayExceptSelf(int[] nums)
        {
            var listed = new List<int>(nums);
            int n = listed.Count();
            var result = new int[n];
            var product = 1;
            for (int i = 0; i < listed.Count(); i++)
                product *= listed[i];

            var tempProduct = product;

            for (int i = 0; i < n; i++)
            {
                if (listed[i] == 0)
                {
                    var newProd = 1;

                    for (int j = 0; j < listed.Count(); j++)
                    {
                        if (i == j)
                            continue;

                        newProd *= listed[j];
                    };

                    result[i] = newProd;
                }
                else
                {
                    product /= listed[i];
                    result[i] = product;
                    product = tempProduct;
                }
            }

            return result;
        }
    }
}
