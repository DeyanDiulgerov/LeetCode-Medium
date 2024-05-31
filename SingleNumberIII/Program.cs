using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumberIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SingleNumberIII(new int[] { 1, 2, 1, 3, 2, 5 })));
            Console.WriteLine(String.Join(",", SingleNumberIII(new int[] { -1, 0 })));
            Console.WriteLine(String.Join(",", SingleNumberIII(new int[] { 0, 1 })));
        }

        public static int[] SingleNumberIII(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach(int num in nums)
            {
                if(set.Add(num) == false)
                    set.Remove(num);
            }
            return set.ToArray();
        }
    }
}
