using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumberOfDistinctIntegersAfterReverseOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountNumberOfDistinctIntegersAfterReverseOperations(new int[] { 1, 13, 10, 12, 31 }));
            Console.WriteLine(CountNumberOfDistinctIntegersAfterReverseOperations(new int[] { 2, 2, 2 }));
        }

        public static int CountNumberOfDistinctIntegersAfterReverseOperations(int[] nums)
        {
            var listedNums = new List<int>(nums);

            foreach (var numm in nums)
            {
                int num = numm;
                int result = 0;
                while (num > 0)
                {
                    result = result * 10 + num % 10;
                    num /= 10;
                }

                listedNums.Add(result);
            }

            Console.WriteLine(String.Join(",", listedNums));
            return listedNums.Distinct().Count();
        }
    }
}
