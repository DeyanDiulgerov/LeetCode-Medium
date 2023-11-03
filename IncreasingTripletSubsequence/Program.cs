using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingTripletSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IncreasingTripletSubsequence(new int[] { 1, 2, 2147483647 }));
            Console.WriteLine(IncreasingTripletSubsequence(new int[] { 4, 5, 2147483647, 1, 2 }));
            Console.WriteLine(IncreasingTripletSubsequence(new int[] { 1, 5, 0, 4, 1, 3 }));
            Console.WriteLine(IncreasingTripletSubsequence(new int[] { 20, 100, 10, 12, 5, 13 }));
            Console.WriteLine(IncreasingTripletSubsequence(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(IncreasingTripletSubsequence(new int[] { 5, 4, 3, 2, 1 }));
            Console.WriteLine(IncreasingTripletSubsequence(new int[] { 2, 1, 5, 0, 4, 6 }));
        }

        public static bool IncreasingTripletSubsequence(int[] nums)
        {
            if (nums.Length < 3)
                return false;

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= smallest)
                    smallest = nums[i];
                else if (nums[i] <= secondSmallest)
                    secondSmallest = nums[i];
                else
                    return true;
            }
            return false;
        }
    }
}
