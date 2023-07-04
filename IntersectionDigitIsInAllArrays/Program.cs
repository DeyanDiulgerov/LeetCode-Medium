using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionDigitIsInAllArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] nums1 = new int[][]
            {
                new int[] {3,1,2,4,5},
                new int[] {1,2,3,4},
                new int[] {3,4,5,6},
            };

            int[][] nums2 = new int[][]
           {
                new int[] {1,2,3},
                new int[] {4,5,6},
           };

            Console.WriteLine(String.Join(",", IntersectionDigitIsInAllArrays(nums1)));
            Console.WriteLine(String.Join(",", IntersectionDigitIsInAllArrays(nums2)));
        }

        public static IList<int> IntersectionDigitIsInAllArrays(int[][] nums)
        {
            var dictionary = new Dictionary<int, int>();
            var resultList = new List<int>();

            foreach (var numArr in nums)
            {
                foreach (var num in numArr)
                {
                    if (!dictionary.ContainsKey(num))
                        dictionary.Add(num, 1);
                    else
                        dictionary[num]++;
                }
            }

            foreach (var kvp in dictionary.Where(x => x.Value == nums.Count()).OrderBy(x => x.Key))
            {
                if (kvp.Value == 0)
                    return new List<int>();
                else
                {
                    resultList.Add(kvp.Key);
                }
            }

            return resultList;
        }
    }
}
