using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerWithMostWater
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine(ContainerWithMostWater(new int[] { 2, 3, 4, 5, 18, 17, 6 }));
            Console.WriteLine(ContainerWithMostWater(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
            Console.WriteLine(ContainerWithMostWater(new int[] { 1, 1 }));
        }

        public static int ContainerWithMostWater(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int max = 0;

            while (left < right)
            {
                int min = Math.Min(height[left], height[right]);
                int newMax = min * (right - left);
                max = Math.Max(max, newMax);

                if (height[left] > height[right])
                    right--;
                else
                    left++;
            }
            return max;
        }
    }
}
