using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximizeHappinessOfSelectedChildren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximizeHappinessOfSelectedChildren(new int[] { 12, 1, 42 }, 3));
            Console.WriteLine(MaximizeHappinessOfSelectedChildren(new int[] { 1, 2, 3 }, 2));
            Console.WriteLine(MaximizeHappinessOfSelectedChildren(new int[] { 1, 1, 1, 1 }, 2));
            Console.WriteLine(MaximizeHappinessOfSelectedChildren(new int[] { 2, 3, 4, 5 }, 1));
        }
        public static long MaximizeHappinessOfSelectedChildren(int[] happiness, int k)
        {
            Array.Sort(happiness);
            long sumHappy = 0;
            int decreasedCount = 0;
            for(int i = happiness.Length - 1; i >= 0; i--)
            {
                int curr = happiness[i] - decreasedCount;
                if(k == decreasedCount || curr <= 0)
                    break;
                sumHappy += curr;
                decreasedCount++;
            }
            return sumHappy;
        }
    }
}
