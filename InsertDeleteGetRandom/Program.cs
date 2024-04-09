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
            HashSet<int> set;
            Random random;
            public RandomizedSet()
            {
                set = new HashSet<int>();
                random = new Random();
            }            
            public bool Insert(int val)
                => set.Add(val);  
            public bool Remove(int val)
                => set.Remove(val);
            public int GetRandom()
                => set.ElementAt(random.Next(set.Count));
        }
    }
}
