using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakIndexInMountainArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PeakIndexInMountainArray(new int[] { 0, 1, 0 }));
            Console.WriteLine(PeakIndexInMountainArray(new int[] { 0, 2, 1, 0 }));
            Console.WriteLine(PeakIndexInMountainArray(new int[] { 0, 10, 5, 2 }));
        }

        public static int PeakIndexInMountainArray(int[] arr)
        {
            var index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i >= 1)
                {
                    while (arr[i] > arr[i - 1])
                    {
                        i++;
                        if (i == arr.Length - 1)
                            break;
                    }
                    i--;

                    index = Array.IndexOf(arr, arr[i]);
                    break;
                }
            }

            return index;
        }
    }
}
