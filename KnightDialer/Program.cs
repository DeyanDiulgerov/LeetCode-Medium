using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightDialer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", KnightDialer(1)));
            Console.WriteLine(String.Join(",", KnightDialer(2)));
            Console.WriteLine(String.Join(",", KnightDialer(3131)));
        }
        public static int KnightDialer(int n)
        {
            int mod = 1_000_000_007;
            var arr = new long[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            var temp = new long[10];

            for (int i = 1; i < n; i++)
            {
                temp[0] = (arr[4] + arr[6]) % mod;
                temp[1] = (arr[6] + arr[8]) % mod;
                temp[2] = (arr[7] + arr[9]) % mod;
                temp[3] = (arr[4] + arr[8]) % mod;
                temp[4] = (arr[0] + arr[3] + arr[9]) % mod;
                temp[6] = (arr[0] + arr[1] + arr[7]) % mod;
                temp[7] = (arr[2] + arr[6]) % mod;
                temp[8] = (arr[1] + arr[3]) % mod;
                temp[9] = (arr[2] + arr[4]) % mod;

                Buffer.BlockCopy(temp, 0, arr, 0, temp.Length * sizeof(Int64));
            }
            Int64 result = 0;
            for (int i = 0; i < 10; i++)
                result += (arr[i] % mod);

            return (int)(result % mod);
        }
    }
}
