using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JumpGame(new int[] { 3, 2, 1, 0, 4 }));
            Console.WriteLine(JumpGame(new int[] { 2, 3, 1, 1, 4 }));
        }

        public static bool JumpGame(int[] nums)
        {
            // The end of the array is true, since that means we are at the solution.
            int nearestTrue = nums.Length - 1;

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (i + nums[i] >= nearestTrue)
                {
                    nearestTrue = i;
                }
            }

            // If the nearest true is the start, the entire solution is jumpable.
            if (nearestTrue == 0)
                return true;
            else
                return false;
        }
    }
}
