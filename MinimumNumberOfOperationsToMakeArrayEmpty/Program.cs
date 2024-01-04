using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumNumberOfOperationsToMakeArrayEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumNumberOfOperationsToMakeArrayEmpty(new int[] { 14, 12, 14, 14, 12, 14, 14, 12, 12, 12, 12, 14, 14, 12, 14, 14, 14, 12, 12 }));
            Console.WriteLine(MinimumNumberOfOperationsToMakeArrayEmpty(new int[] { 2, 3, 3, 2, 2, 4, 2, 3, 4 }));
            Console.WriteLine(MinimumNumberOfOperationsToMakeArrayEmpty(new int[] { 2, 1, 2, 2, 3, 3 }));
        }
        public static int MinimumNumberOfOperationsToMakeArrayEmpty(int[] nums)
        {
            Dictionary<int, int> numAndOccurrenceMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!numAndOccurrenceMap.ContainsKey(nums[i]))
                    numAndOccurrenceMap.Add(nums[i], 1);
                else
                    numAndOccurrenceMap[nums[i]]++;
            }
            int operationsResult = 0;
            foreach (var kvp in numAndOccurrenceMap)
            {
                if (kvp.Value % 3 == 0)
                    operationsResult += kvp.Value / 3;
                else
                {
                    int tempValue = kvp.Value;
                    while (tempValue > 0)
                    {
                        if (tempValue == 4)
                        {
                            operationsResult += 2;
                            tempValue = 0;
                            break;
                        }

                        operationsResult++;
                        if (tempValue == 2)
                            tempValue = 0;
                        else
                            tempValue -= 3;
                    }
                    if (tempValue < 0)
                        return -1;
                }
            }
            return operationsResult;
        }
    }
}
