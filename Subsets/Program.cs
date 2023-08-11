using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input3 = Subsets(new int[] { 3, 2, 4, 1 });
            var input5 = Subsets(new int[] { 3, 9 });
            var input4 = Subsets(new int[] { 4, 1, 0 });
            var input1 = Subsets(new int[] { 1, 2, 3 });
            var input2 = Subsets(new int[] { 0 });

            foreach (var item in input3)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input5)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input4)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input1)
                Console.WriteLine(String.Join(",", item));
            foreach (var item in input2)
                Console.WriteLine(String.Join(",", item));
        }

        public static IList<IList<int>> Subsets(int[] nums)
        {
            var subsets = new List<IList<int>>();
            subsets.Add(new List<int>());

            for (int i = 0; i < nums.Length; i++)
            {
                int count = subsets.Count;
                for (int j = 0; j < count; j++)
                {
                    var temp = subsets[j].ToList();
                    temp.Add(nums[i]);
                    subsets.Add(temp);
                }
            }
            return subsets;
        }
    }
}
