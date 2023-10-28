using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReduceArraySizeToTheHalf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReduceArraySizeToTheHalf(new int[] { 9, 77, 63, 22, 92, 9, 14, 54, 8, 38, 18, 19, 38, 68, 58, 19 }));
            Console.WriteLine(ReduceArraySizeToTheHalf(new int[] { 3, 3, 3, 3, 5, 5, 5, 2, 2, 7 }));
            Console.WriteLine(ReduceArraySizeToTheHalf(new int[] { 7, 7, 7, 7, 7, 7 }));
        }

        public static int ReduceArraySizeToTheHalf(int[] arr)
        {
            var numAndCountDict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!numAndCountDict.ContainsKey(arr[i]))
                    numAndCountDict.Add(arr[i], 1);
                else
                    numAndCountDict[arr[i]]++;
            }

            var listed = new List<int>();

            foreach (var kvp in numAndCountDict.OrderByDescending(x => x.Value))
                for (int i = 0; i < kvp.Value; i++)
                    listed.Add(kvp.Key);

            int counter = 0;
            while (listed.Count() > arr.Length / 2)
            {
                listed.RemoveRange(0, numAndCountDict[listed[0]]);
                counter++;
            }

            return counter;
        }
    }
}
