using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumberII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SingleNumber(new int[] {2,2,3,2}));
            Console.WriteLine(SingleNumber(new int[] { 0, 1, 0, 1, 0, 1, 99 }));
        }
        public static int SingleNumber(int[] nums)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(nums[i]))
                    map.Add(nums[i], 1);
                else
                    map[nums[i]]++;
            }
            return map.First(x => x.Value == 1).Key;
        }
    }
}
