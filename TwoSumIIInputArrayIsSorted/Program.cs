using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumIIInputArrayIsSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", TwoSumIIInputArrayIsSorted(new int[] { 2, 7, 11, 15 }, 9)));
            Console.WriteLine(String.Join(",", TwoSumIIInputArrayIsSorted(new int[] { 2, 3, 4 }, 6)));
            Console.WriteLine(String.Join(",", TwoSumIIInputArrayIsSorted(new int[] { -1, 0 }, -1)));
        }
        public static int[] TwoSumIIInputArrayIsSorted(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;
            while(left < right)
            {
                if(numbers[left] + numbers[right] > target)
                    right--;
                else if(numbers[left] + numbers[right] < target)
                    left++;
                else    
                    break;
            }
            return new int[] {left + 1, right + 1};
        }
    }
}
