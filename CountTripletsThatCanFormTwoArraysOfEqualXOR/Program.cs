using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTripletsThatCanFormTwoArraysOfEqualXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountTripletsThatCanFormTwoArraysOfEqualXOR(new int[] { 2, 3, 1, 6, 7 }));
            Console.WriteLine(CountTripletsThatCanFormTwoArraysOfEqualXOR(new int[] { 1, 1, 1, 1, 1 }));
        }
        public static int CountTripletsThatCanFormTwoArraysOfEqualXOR(int[] arr)
        {
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j; k < arr.Length; k++)
                    {
                        int a = 0;
                        int b = 0;

                        for (int A = i; A < j; A++)
                            a ^= arr[A];
                        for (int B = j; B <= k; B++)
                            b ^= arr[B];

                        if (a == b)
                            result++;
                    }
                }
            }
            return result;
        }
    }
}
