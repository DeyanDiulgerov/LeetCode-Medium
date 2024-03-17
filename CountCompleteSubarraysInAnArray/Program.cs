using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCompleteSubarraysInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountCompleteSubarraysInAnArray(new int[] { 1, 3, 1, 2, 2 }));
            Console.WriteLine(CountCompleteSubarraysInAnArray(new int[] { 5, 5, 5, 5 }));
        }
        public static int CountCompleteSubarraysInAnArray(int[] nums)
        {
            int left = 0, right = 0;
            int res = 0;
            int distinctCount = nums.Distinct().Count();
            while (left < nums.Length)
            {
                HashSet<int> subArr = new HashSet<int>();
                while (right < nums.Length)
                {
                    subArr.Add(nums[right]);
                    right++;
                    if (subArr.Count() == distinctCount)
                        res++;
                }
                for (int j = 0; j < subArr.Count(); j++)
                {
                    subArr.Remove(subArr.ElementAt(0));
                    if (subArr.Count() == distinctCount)
                        res++;
                }
                left++;
                right = left;
            }
            return res;
        }
    }
}
