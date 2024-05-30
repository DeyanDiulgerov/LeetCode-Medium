using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthSmallestPrimeFraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", KthSmallestPrimeFraction(new int[] { 1, 2, 3, 5 }, 3)));
            Console.WriteLine(String.Join(",", KthSmallestPrimeFraction(new int[] { 1, 7 }, 1)));
        }
        public static int[] KthSmallestPrimeFraction(int[] arr, int k)
        {
            List<double> fractions = new List<double>();
            var map = new Dictionary<double, int[]>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    double newFraction = (double)arr[i] / arr[j];
                    fractions.Add(newFraction);
                    map.Add(newFraction, new int[] { arr[i], arr[j] });
                }
            }
            fractions.Sort();
            return map[fractions[k - 1]];
        }
    }
}
