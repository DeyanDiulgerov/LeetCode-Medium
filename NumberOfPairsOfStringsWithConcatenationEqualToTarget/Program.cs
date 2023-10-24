using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfPairsOfStringsWithConcatenationEqualToTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfPairsOfStringsWithConcatenationEqualToTarget(
                new string[] { "777", "7", "77", "77" }, "7777"));
            Console.WriteLine(NumberOfPairsOfStringsWithConcatenationEqualToTarget(
                new string[] { "123", "4", "12", "34" }, "1234"));
            Console.WriteLine(NumberOfPairsOfStringsWithConcatenationEqualToTarget(
                new string[] { "1", "1", "1" }, "11"));
        }
        public static int NumberOfPairsOfStringsWithConcatenationEqualToTarget(string[] nums, string target)
        {
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    var testNum = nums[i];
                    testNum += nums[j];

                    if (i != j && testNum == target)
                        counter++;
                }
            }
            return counter;
        }
    }
}
