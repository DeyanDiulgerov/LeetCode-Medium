using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRobber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HouseRobber(new int[] { 1, 3, 1 }));
            Console.WriteLine(HouseRobber(new int[] { 1, 2 }));
            Console.WriteLine(HouseRobber(new int[] { 1, 2, 3, 1 }));
            Console.WriteLine(HouseRobber(new int[] { 2, 7, 9, 3, 1 }));
        }

        public static int HouseRobber(int[] nums)
        {
            int pp = 0;
            int p = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int t = p;
                p = Math.Max(p, pp + nums[i]);
                pp = t;
            }
            return p;
        }
    }
}
