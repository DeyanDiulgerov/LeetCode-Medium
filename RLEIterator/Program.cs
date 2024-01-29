using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLEIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RLEIterator rle = new RLEIterator(new int[] { 3, 8, 0, 9, 2, 5 });
            rle.Next(2);
            rle.Next(1);
            rle.Next(1);
            rle.Next(2);
        }
        public class RLEIterator
        {
            List<int[]> elementAndCount;
            public RLEIterator(int[] encoding)
            {
                elementAndCount = new List<int[]>();
                for (int i = 0; i < encoding.Length - 1; i += 2)
                {
                    if (encoding[i] == 0)
                        continue;

                    elementAndCount.Add(new int[] { encoding[i + 1], encoding[i] });
                }
            }

            public int Next(int n)
            {
                int lastSeen = 0;
                for (int i = 0; i < elementAndCount.Count; i++)
                {
                    if (elementAndCount[i][1] > n)
                    {
                        var curr = elementAndCount.ElementAt(i);
                        elementAndCount[i][1] -= n;
                        return elementAndCount[i][0];
                    }
                    else if (elementAndCount[i][1] == n)
                    {
                        int[] curr = elementAndCount[i];
                        elementAndCount.RemoveAt(i);
                        return curr[0];
                    }
                    else// if(elementCountMap.ElementAt(i).Value < n)
                    {
                        lastSeen = elementAndCount[i][0];
                        int newValue = elementAndCount[i][1];
                        n -= newValue;
                        elementAndCount.RemoveAt(i);
                        i--;
                        if (n <= 0)
                            break;
                    }
                }
                if (elementAndCount.Count() == 0)
                    return -1;
                return lastSeen;
            }
        }
    }
}
