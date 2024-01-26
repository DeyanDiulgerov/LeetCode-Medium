using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestNumberInInfiniteSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmallestInfiniteSet set = new SmallestInfiniteSet();
            set.AddBack(2);
            set.PopSmallest();
            set.PopSmallest();
            set.PopSmallest();
            set.AddBack(1);
            set.PopSmallest();
            set.PopSmallest();
            set.PopSmallest();
        }
        public class SmallestInfiniteSet
        {
            List<int> dataSet;
            public SmallestInfiniteSet()
            {
                dataSet = new List<int>();
                for (int i = 1; i <= 1000; i++)
                {
                    dataSet.Add(i);
                }
            }
            public int PopSmallest()
            {
                int removed = dataSet[0];
                dataSet.RemoveAt(0);
                return removed;
            }
            public void AddBack(int num)
            {
                if (!dataSet.Contains(num))
                {
                    for (int i = 0; i < dataSet.Count(); i++)
                    {
                        if (num <= dataSet[i])
                        {
                            dataSet.Insert(i, num);
                            break;
                        }
                    }
                }
            }
        }
    }
}
