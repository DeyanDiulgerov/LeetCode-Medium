using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindUniqueBinaryString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindUniqueBinaryString(new string[] { "01", "10" }));
            Console.WriteLine(FindUniqueBinaryString(new string[] { "00", "01" }));
            Console.WriteLine(FindUniqueBinaryString(new string[] { "111", "011", "001" }));
        }
        public static string FindUniqueBinaryString(string[] nums)
        {
            int n = nums.Length;//==nums[i].Length;
            for (int i = 0; i <= n + 1; i++)
            {
                string binary = Convert.ToString(i, 2);
                while (binary.Length < n)
                    binary += "0";
                if (!nums.Contains(binary))
                    return binary;
            }
            return "";
        }
    }
}
