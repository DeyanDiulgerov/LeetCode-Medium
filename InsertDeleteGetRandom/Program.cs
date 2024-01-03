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
                if(!set.Contains(val))
                {
                    set.Add(val);
                    Console.WriteLine($"{val} was added to the set!");
                    return true;
                }
                Console.WriteLine($"{val} is already in the set");
                return false;
            }
            public bool Remove(int val)
            {
                if(set.Contains(val))
                {
                    set.Remove(val);
                    Console.WriteLine($"{val} was removed from the set!");
                    return true;
                }
                Console.WriteLine($"The set did not contain {val}");
                return false;
            }
            public int GetRandom()
            {
                Random random = new Random();
                int index = random.Next(set.Count);
                int result = set[index];
                Console.WriteLine($"The random element is {result}");
                return result;
            }
        }
    }
}
