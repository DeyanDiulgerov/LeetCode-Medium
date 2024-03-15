using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SortColors(new int[] { 2, 0, 2, 1, 1, 0 })));
            Console.WriteLine(String.Join(",", SortColors(new int[] { 2, 0, 1 })));
        }
        //2nd way - In Place
        public static int[] SortColors(int[] nums)
        {
            var sorted = new List<int>(nums);
            sorted.Sort();
            if (nums.SequenceEqual(sorted))
                return nums;

            int zeroCount = 0, oneCount = 0, twoCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                switch (nums[i])
                {
                    case 0:
                        zeroCount++;
                        break;
                    case 1:
                        oneCount++;
                        break;
                    case 2:
                        twoCount++;
                        break;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if(zeroCount > 0)
                {
                    nums[i] = 0;
                    zeroCount--;
                }
                else if(oneCount > 0)
                {
                    nums[i] = 1;
                    oneCount--;
                }
                else
                {
                    nums[i] = 2;
                    twoCount--;
                }
            }
            return nums;
        }
        //1st Way - really old
        public static int[] SortColors(int[] nums)
        {
            var zeroesCount = nums.Where(x => x == 0).Count();
            var onesCount = nums.Where(x => x == 1).Count();
            var twosCount = nums.Where(x => x == 2).Count();
            var resultList = new List<int>();

            for (int i = 0; i < zeroesCount; i++)
                resultList.Add(0);
            for (int i = 0; i < onesCount; i++)
                resultList.Add(1);
            for (int i = 0; i < twosCount; i++)
                resultList.Add(2);

            return resultList.ToArray();
        }
    }
}
