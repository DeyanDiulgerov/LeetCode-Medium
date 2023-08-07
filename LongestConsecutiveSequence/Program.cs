using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestConsecutiveSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestConsecutiveSequence(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }));
            Console.WriteLine(LongestConsecutiveSequence(new int[] { 1, 2, 0, 1 }));
            Console.WriteLine(LongestConsecutiveSequence(new int[] { 0 }));
            Console.WriteLine(LongestConsecutiveSequence(new int[] { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 }));
            Console.WriteLine(LongestConsecutiveSequence(new int[] { 100, 4, 200, 1, 3, 2 }));
            Console.WriteLine(LongestConsecutiveSequence(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }));
        }

        public static int LongestConsecutiveSequence(int[] nums)
        {
            if (nums.Count() == 0)
                return 0;

            int counter = 1;
            var allCounters = new List<int>();
            Array.Sort(nums);
            nums = nums.Distinct().ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length - 1)
                {
                    //var test = nums[i];

                    if (nums[i] == nums[i + 1] - 1)
                        counter++;
                    else
                    {
                        allCounters.Add(counter);
                        counter = 1;
                    }
                }
            }
            allCounters.Add(counter);

            allCounters.Sort();
            //Console.WriteLine(String.Join(",", allCounters));

            return allCounters.Last();
        }
    }
}
