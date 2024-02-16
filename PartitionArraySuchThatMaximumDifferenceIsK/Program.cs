using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionArraySuchThatMaximumDifferenceIsK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PartitionArraySuchThatMaximumDifferenceIsK(new int[] { 3, 6, 1, 2, 5 }, 2));
            Console.WriteLine(PartitionArraySuchThatMaximumDifferenceIsK(new int[] { 1, 2, 3 }, 1));
            Console.WriteLine(PartitionArraySuchThatMaximumDifferenceIsK(new int[] { 2, 2, 4, 5 }, 0));
        }
        public static int PartitionArraySuchThatMaximumDifferenceIsK(int[] nums, int k)
        {
            if (k == 0)
                return nums.Distinct().Count();
            var listed = new List<int>(nums);
            int result = 0;
            while (listed.Count() > 0)
            {
                int max = listed.Max();
                listed.Remove(max);
                for (int i = 0; i < listed.Count(); i++)
                {
                    if (listed[i] >= max - k)
                    {
                        listed.RemoveAt(i);
                        i--;
                    }
                }
                result++;
            }
            return result;
        }
    }
}
