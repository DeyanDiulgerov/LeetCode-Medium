using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumNumberOfOperationsToMakeWordKPeriodic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumNumberOfOperationsToMakeWordKPeriodic("hnccccajbwccajut", 2));
            Console.WriteLine(MinimumNumberOfOperationsToMakeWordKPeriodic("leetcodeleet", 4));
            Console.WriteLine(MinimumNumberOfOperationsToMakeWordKPeriodic("leetcoleet", 2));
        }
        public static int MinimumNumberOfOperationsToMakeWordKPeriodic(string word, int k)
        {
            var map = new Dictionary<string, int>();
            for (int i = 0; i < word.Length; i += k)
            {
                string substring = word.Substring(i, k);
                if (!map.ContainsKey(substring))
                    map.Add(substring, 1);
                else
                    map[substring]++;
            }
            Console.WriteLine(String.Join(",", map));
            var maxLength = map.OrderByDescending(x => x.Value).First();
            int res = word.Length - (maxLength.Key.Length * maxLength.Value);
            return res / k;
        }
    }
}
