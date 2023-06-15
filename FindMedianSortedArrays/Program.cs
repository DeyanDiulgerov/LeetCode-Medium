using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMedianSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[] { 1, 3 };
            var array12 = new int[] { 2 };

            var array2 = new int[] { 1, 2 };
            var array22 = new int[] { 3, 4 };

            Console.WriteLine(FindMedianSortedArrays(array2, array22));
            Console.WriteLine(FindMedianSortedArrays(array1, array12));
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            //Put everything together and sort
            var list1 = new List<int>(nums1);

            foreach (var item in nums2)
            {
                list1.Add(item);
            }
            list1.Sort();

            double median = 0.0;

            //Even count in list
            if (list1.Count % 2 == 0)
            {
                //if count == 6 take indixes 3 and 2
                //if count == 4 take indixes 2 and 1
                //if count == 10 take indixes 5 and 4
                double firstIndex = list1[list1.Count / 2];
                double secondIndex = list1[(list1.Count / 2) - 1];
                median = (firstIndex + secondIndex) / 2;
            }
            //Odd count in list
            else
            {
                //if count == 5 take count - 1 / 2 == 2
                //if count == 7 take 3
                double num = list1[(list1.Count - 1) / 2];
                median = num;
            }

            return median;
        }
    }
}
