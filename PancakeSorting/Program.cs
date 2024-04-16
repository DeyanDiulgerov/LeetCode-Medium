using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PancakeSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", PancakeSorting(new int[] { 3, 2, 4, 1 })));
            Console.WriteLine(String.Join(",", PancakeSorting(new int[] { 1, 2, 3 })));
            // 4,2,3,1
            // 1,3,2,4
            // 3,1,2,4
            // 2,1,3,4
            // 1,2,3,4
        }
        public static IList<int> PancakeSorting(int[] arr)
        {
            int maxValue = arr.Max();
            List<int> result = new List<int>();
            List<int> sorted = new List<int>(arr);
            sorted.Sort();
            while (!sorted.SequenceEqual(arr))
            {
                int index = Array.IndexOf(arr, maxValue);
                if (index != 0)
                    Swap(0, index);
                Swap(0, maxValue - 1);
                maxValue--;
                result.Add(index + 1);
                result.Add(maxValue + 1);
            }
            return result;
            void Swap(int left, int right)
            {
                while (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
        }
    }
}
