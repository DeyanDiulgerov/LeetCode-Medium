using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThreshold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThreshold(new int[] { 2, 2, 2, 2, 5, 5, 5, 8 }, 3, 4));
            Console.WriteLine(NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThreshold(new int[] { 11, 13, 17, 23, 29, 31, 7, 5, 2, 3 }, 3, 5));
        }
        public static int NumberOfSubarraysOfSizeKAndAverageGreaterThanOrEqualToThreshold(int[] arr, int k, int threshold)
        {
            int counter = 0;
            for (int i = 0; i <= arr.Length - k; i++)
            {
                int sum = 0;
                for (int j = i; j < i + k; j++)
                    sum += arr[j];

                if (sum / k >= threshold)
                    counter++;
            }
            return counter;
        }
    }
}
