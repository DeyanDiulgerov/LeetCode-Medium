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
            int n = happiness.Length;
            long result = 0;
            int happyCounter = 0;
            Array.Sort(happiness);
            for (int i = n - 1; i >= 0; i--)
            {
                if (happiness[i] - happyCounter < 0)
                    break;
                result += happiness[i] - happyCounter;
                happyCounter++;
                if (happyCounter == k)
                    break;
            }
            return result;
        }
    }
}
