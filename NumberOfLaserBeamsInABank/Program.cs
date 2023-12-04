using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfLaserBeamsInABank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfLaserBeamsInABank(new string[] { "011001", "000000", "010100", "001000" }));
            Console.WriteLine(NumberOfLaserBeamsInABank(new string[] { "000", "111", "000" }));
        }
        public static int NumberOfLaserBeamsInABank(string[] bank)
        {
            int oldCount = 0, newCount = 0;
            int result = 0;
            bool IsOld = false;

            for (int i = 0; i < bank.Length; i++)
            {
                IsOld = oldCount == 0 ? false : true;

                for (int j = 0; j < bank[i].Length; j++)
                {
                    if (bank[i][j] == '1' && IsOld)
                        newCount++;
                    else if (bank[i][j] == '1' && !IsOld)
                        oldCount++;
                }
                if (IsOld && newCount != 0)
                {
                    result += oldCount * newCount;
                    oldCount = 0;
                    newCount = 0;
                    i--;
                }
            }
            return result;
        }
    }
}
