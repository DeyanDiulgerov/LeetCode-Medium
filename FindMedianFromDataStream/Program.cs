using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMedianFromDataStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine($"------------------------- Hello ----------------------------");
            MedianFinder finder = new MedianFinder();
            finder.AddNum(49998);
            Console.WriteLine($"The Median so far is: {finder.FindMedian()} :)");
            finder.AddNum(49994);
            Console.WriteLine($"The Median so far is: {finder.FindMedian()} :)");
            finder.AddNum(49992);
            Console.WriteLine($"The Median so far is: {finder.FindMedian()} :)");
            finder.AddNum(49990);
            Console.WriteLine($"The Median so far is: {finder.FindMedian()} :)");
            finder.AddNum(49979);
            Console.WriteLine($"The Median so far is: {finder.FindMedian()} :)");
            finder.AddNum(49977);
            Console.WriteLine($"The Median so far is: {finder.FindMedian()} :)");
            Console.WriteLine($"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            Console.WriteLine($"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine($"------------------------- Hello2 ----------------------------");
            MedianFinder finder2 = new MedianFinder();
            finder2.AddNum(155);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(66);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(114);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(0);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(60);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(73);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(109);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(26);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(154);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(0);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(107);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(75);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(9);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(57);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(53);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(6);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(85);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(151);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(12);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(110);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(64);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(103);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(42);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(103);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            finder2.AddNum(126);
            Console.WriteLine($"The Median so far is: {finder2.FindMedian()} :)");
            Console.WriteLine($"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        }
        public class MedianFinder
        {
            List<int> allNums = new List<int>();
            public MedianFinder()
            {
                allNums = new List<int>();
            }

            public void AddNum(int num)
            {
                // Binary Search
                int left = 0, right = allNums.Count();
                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (num < allNums[mid])
                        right = mid;
                    else
                        left = mid + 1;
                }
                allNums.Insert(right, num);
                Console.WriteLine($"Added Number: {num}");
                Console.WriteLine(String.Join(",", allNums));
            }

            public double FindMedian()
            {
                // we need 2 nums
                if (allNums.Count() % 2 == 0)
                {
                    int firstIndex = allNums.Count() / 2 - 1;
                    int secondIndex = allNums.Count() / 2;

                    double result = (double)(allNums[firstIndex] + (double)allNums[secondIndex]) / 2;
                    return result;
                }
                // we need only one
                else
                {
                    int index = allNums.Count() / 2;
                    return (double)allNums[index];
                }
            }
        }
    }
}
