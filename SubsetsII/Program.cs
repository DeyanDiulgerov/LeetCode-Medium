using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetsII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in SubsetsII(new int[] { 4, 4, 4, 1, 4 }))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in SubsetsII(new int[] { 1, 2, 2 }))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in SubsetsII(new int[] { 0 }))
                Console.WriteLine(String.Join(",", item));
            foreach (var item in SubsetsII(new int[] { 1, 2, 3, 4 }))
                Console.WriteLine(String.Join(",", item));
        }

        public static IList<IList<int>> SubsetsII(int[] nums)
        {
            var result = new List<IList<int>>();
            result.Add(new List<int>() { });

            for (int i = 0; i < nums.Length; i++)
            {
                int count = result.Count();
                for (int j = 0; j < count; j++)
                {
                    var temp = result[j].ToList();
                    temp.Add(nums[i]);
                    temp.Sort();
                    if (!result.Any(x => x.SequenceEqual(temp)))
                        result.Add(temp);
                }
            }
            return result;
        }
    }
}
