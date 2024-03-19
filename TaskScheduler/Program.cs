using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TaskScheduler(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2));
            Console.WriteLine(TaskScheduler(new char[] { 'A', 'C', 'A', 'B', 'D', 'B' }, 1));
            Console.WriteLine(TaskScheduler(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 3));
        }
        public static int TaskScheduler(char[] tasks, int n)
        {
            var map = new Dictionary<char, int>();
            for (int i = 0; i < tasks.Length; i++)
            {
                if (!map.ContainsKey(tasks[i]))
                    map.Add(tasks[i], 1);
                else
                    map[tasks[i]]++;
            }
            List<char> separated = new List<char>();
            int counter = -1;
            while (map.Count() > 0)
            {
                foreach (var kvp in map.OrderByDescending(x => x.Value))
                {
                    separated.Add(kvp.Key);
                    counter++;
                    map[kvp.Key]--;
                    if (map[kvp.Key] == 0)
                        map.Remove(kvp.Key);
                    if (counter == n)
                        break;
                }
                if (map.Count() == 0)
                    break;
                while (counter < n)
                {
                    separated.Add('.');
                    counter++;
                }
                counter = -1;
            }
            return separated.Count();
        }
    }
}
