using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKthFactorOfN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KthFactor(12, 3));
            Console.WriteLine(KthFactor(7, 2));
            Console.WriteLine(KthFactor(4, 4));
        }
        //2nd Way stops after k elements
         public static int KthFactor2(int n, int k)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    set.Add(i);
                if (set.Count() == k)
                    return i;
            }
            return -1;
        }
        //Doesnt stop and finds all elements
        //Then we return the kth one
        public static int KthFactor(int n, int k)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    set.Add(i);

            return k > set.Count ? -1 : set.ElementAt(k - 1);
        }
    }
}
