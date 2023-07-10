using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupThePeopleGivenTheGroupSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = GroupThePeopleGivenTheGroupSize(new int[] { 3, 3, 3, 3, 3, 1, 3 });
            var input2 = GroupThePeopleGivenTheGroupSize(new int[] { 2, 1, 3, 3, 3, 2 });

            foreach (var item in input1)
                Console.Write($"[{String.Join(",", item)}]");

            Console.WriteLine($"\n-----------------------------------------------------");

            foreach (var item in input2)
                Console.Write($"[{String.Join(",", item)}]");

            Console.WriteLine($"\n-----------------------------------------------------");
        }

        public static IList<IList<int>> GroupThePeopleGivenTheGroupSize(int[] groupSizes)
        {
            // index = person
            // groupSizes[index] = groupSize
            // groupSizes[1] = 3 == person 1 must be in a group size of 3

            var resultList = new List<IList<int>>();
            var usedIndices = new List<int>();
            var personIndexAndGroupSize = new Dictionary<int, int>();
            int n = groupSizes.Length;

            for (int i = 0; i < n; i++)
                personIndexAndGroupSize.Add(i, groupSizes[i]);

            for (int i = 0; i < personIndexAndGroupSize.Count(); i++)
            {
                var newList = new List<int>();
                int counter = 0;

                foreach (var kvp in
                    personIndexAndGroupSize.Where(x => x.Value == personIndexAndGroupSize[i]))
                {
                    if (usedIndices.Contains(kvp.Key))
                        continue;

                    newList.Add(kvp.Key);
                    usedIndices.Add(kvp.Key);

                    counter++;

                    if (newList.Count() == personIndexAndGroupSize[i])
                    {
                        resultList.Add(newList);
                        newList = new List<int>();
                    }
                }
            }

            return resultList;
        }
    }
}
