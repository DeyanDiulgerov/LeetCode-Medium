using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanceSeatAssignmentProbability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AirplanceSeatAssignmentProbability(1));
            Console.WriteLine(AirplanceSeatAssignmentProbability(2));
            Console.WriteLine(AirplanceSeatAssignmentProbability(3));
            Console.WriteLine(AirplanceSeatAssignmentProbability(4));
            Console.WriteLine(AirplanceSeatAssignmentProbability(5));
            Console.WriteLine(AirplanceSeatAssignmentProbability(12));
            Console.WriteLine(AirplanceSeatAssignmentProbability(24));
        }
        public static double AirplanceSeatAssignmentProbability(int n)
            => n == 1 ? n : 0.5;
    }
}
