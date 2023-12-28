using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertDeleteGetRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomizedSet set = new RandomizedSet();
            set.Insert(1);
            set.Remove(2);
            set.Insert(2);
            set.GetRandom();
            set.Remove(1);
            set.Insert(2);
            set.GetRandom();
        }
        public class RandomizedSet
        {
            List<int> set;
            public RandomizedSet()
            {
                set = new List<int>();
            }

            public bool Insert(int val)
            {
                if (!set.Contains(val))
                {
                    set.Add(val);
                    Console.WriteLine(true);
                    return true;
                }
                Console.WriteLine(false);
                return false;
            }

            public bool Remove(int val)
            {
                if (set.Contains(val))
                {
                    set.Remove(val);
                    Console.WriteLine(true);
                    return true;
                }
                Console.WriteLine(false);
                return false;
            }

            public int GetRandom()
            {
                Random random = new Random();
                int index = random.Next(set.Count);
                Console.WriteLine(set[index]);
                return set[index];
            }
        }
    }
}
