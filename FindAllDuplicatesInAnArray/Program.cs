using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllDuplicatesInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", FindAllDuplicatesInAnArray(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 })));
            Console.WriteLine(String.Join(",", FindAllDuplicatesInAnArray(new int[] { 1, 1, 2 })));
            Console.WriteLine(String.Join(",", FindAllDuplicatesInAnArray(new int[] { 1 })));
        }
        public static IList<int> FindAllDuplicatesInAnArray(int[] nums)
        {
            var result = new List<int>();
            var hashset = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!hashset.Contains(nums[i]))
                    hashset.Add(nums[i]);
                else
                    result.Add(nums[i]);
            }
            return result;
        }
    }
}
