using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrappingRainWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TrappingWater(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
            Console.WriteLine(TrappingWater(new int[] { 4, 2, 0, 3, 2, 5 }));
        }

        public static int TrappingWater(int[] height)
        {
            int n = height.Length;
            int[] leftMax = new int[n];
            int lm = 0;

            for (int i = 0; i < n; i++)
            {
                leftMax[i] = lm;
                lm = Math.Max(height[i], lm);
            }

            int[] rightMax = new int[n];
            int rm = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                rightMax[i] = rm;
                rm = Math.Max(rm, height[i]);
            }

            int area = 0;
            var end = new int[n];

            for (int i = 0; i < n; i++)
            {
                int ph = Math.Min(leftMax[i], rightMax[i]);
                int trapped = ph - height[i];
                if (trapped > 0)
                {
                    end[i] = trapped;
                    area += trapped;
                }
            }
            Console.WriteLine(String.Join(",", height));
            Console.WriteLine(String.Join(",", leftMax));
            Console.WriteLine(String.Join(",", rightMax));
            Console.WriteLine(String.Join(",", end));

            return end.Sum();
        }
    }
}
