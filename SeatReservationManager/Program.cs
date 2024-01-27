using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatReservationManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeatManager manager = new SeatManager(5);
            manager.Reserve();
            manager.Reserve();
            manager.Unreserve(2);
            manager.Reserve();
            manager.Reserve();
            manager.Reserve();
            manager.Reserve();
            manager.Unreserve(5);
        }
        public class SeatManager
        {
            List<int> dataSet;
            public SeatManager(int n)
            {
                dataSet = new List<int>();
                for (int i = 1; i <= n; i++)
                    dataSet.Add(i);
            }
            public int Reserve()
            {
                int curr = dataSet[0];
                dataSet.Remove(dataSet[0]);
                Console.WriteLine(String.Join(",", dataSet));
                Console.WriteLine(curr);
                return curr;
            }
            public void Unreserve(int seatNumber)
            {
                int left = 0, right = dataSet.Count();
                int mid = 0;
                while (left < right)
                {
                    mid = left + (right - left) / 2;
                    if (dataSet[mid] <= seatNumber)
                        left = mid + 1;
                    else
                        right = mid;
                }
                dataSet.Insert(right, seatNumber);
                Console.WriteLine(String.Join(",", dataSet));
            }
        }
    }
}
