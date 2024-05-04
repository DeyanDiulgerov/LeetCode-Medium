using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatsToSavePeople
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BoatsToSavePeople(new int[] { 5, 1, 4, 2 }, 6));
            Console.WriteLine(BoatsToSavePeople(new int[] { 1, 2 }, 3));
            Console.WriteLine(BoatsToSavePeople(new int[] { 3, 2, 2, 1 }, 3));
            Console.WriteLine(BoatsToSavePeople(new int[] { 3, 5, 3, 4 }, 5));
        }
        public static int BoatsToSavePeople(int[] people, int limit)
        {
            Array.Sort(people);
            int boats = 0;
            int left = 0, right = people.Length - 1;
            while (left < right)
            {
                if (people[left] + people[right] <= limit)
                    left++;
                right--;
                boats++;
            }
            return boats;
        }
    }
}
