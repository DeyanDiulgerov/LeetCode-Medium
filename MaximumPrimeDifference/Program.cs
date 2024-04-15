using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumPrimeDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumPrimeDifference(new int[] { 4, 2, 9, 5, 3 }));
            Console.WriteLine(MaximumPrimeDifference(new int[] { 4, 8, 2, 8 }));
        }
        public static int MaximumPrimeDifference(int[] nums)
        {
            HashSet<int> primes = new HashSet<int>()
            { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,
              43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
            int first = int.MaxValue, second = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (primes.Contains(nums[i]) && first == int.MaxValue)
                    first = i;
                else if (primes.Contains(nums[i]) && first != int.MaxValue)
                    second = i;
            }
            if (first == int.MaxValue || second == int.MaxValue)
                return 0;
            return Math.Abs(first - second);
        }
    }
}
