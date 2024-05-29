using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfStepsToReduceANumberInBinaryRepresentationsToOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfStepsToReduceANumberInBinaryRepresentationsToOne("1111011110000011100000110001011011110010111001010111110001"));
            Console.WriteLine(NumberOfStepsToReduceANumberInBinaryRepresentationsToOne("1101"));
            Console.WriteLine(NumberOfStepsToReduceANumberInBinaryRepresentationsToOne("10"));
            Console.WriteLine(NumberOfStepsToReduceANumberInBinaryRepresentationsToOne("1"));
        }
        public static int NumberOfStepsToReduceANumberInBinaryRepresentationsToOne(string s)
        {
            BigInteger num = 0;
            foreach (char ch in s)
            {
                num <<= 1;
                num += ch == '1' ? 1 : 0;
            }
            int resCount = 0;
            while (num > 1)
            {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num++;
                resCount++;
            }
            return resCount;
        }
    }
}
