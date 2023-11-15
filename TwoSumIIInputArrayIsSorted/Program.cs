using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumIIInputArrayIsSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", TwoSumIIInputArrayIsSorted(new int[] { 2, 7, 11, 15 }, 9)));
            Console.WriteLine(String.Join(",", TwoSumIIInputArrayIsSorted(new int[] { 2, 3, 4 }, 6)));
            Console.WriteLine(String.Join(",", TwoSumIIInputArrayIsSorted(new int[] { -1, 0 }, -1)));
        }
        public static int[] TwoSumIIInputArrayIsSorted(int[] numbers, int target)
        {
            var numAndIndexDict = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var diff = target - numbers[i];

                if (!numAndIndexDict.ContainsKey(diff))
                {
                    if (!numAndIndexDict.ContainsKey(numbers[i]))
                        numAndIndexDict.Add(numbers[i], i + 1);
                }
                else
                    return new int[] { numAndIndexDict[diff], i + 1 };
            }
            return new int[] { };
        }
    }
}
