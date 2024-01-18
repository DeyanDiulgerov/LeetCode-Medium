using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignBrowserHistory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrowserHistory history = new BrowserHistory("leetcode.com");
            history.Visit("google.com");
            history.Visit("facebook.com");
            history.Visit("youtube.com");
            history.Back(1);
            history.Back(1);
            history.Forward(1);
            history.Visit("linkedin.com");
            history.Forward(2);
            history.Back(2);
            history.Back(7);
        }
        public class BrowserHistory
        {
            List<string> history;
            int index;
            public BrowserHistory(string homepage)
            {
                index = 0;
                history = new List<string>();
                history.Add(homepage);
                Console.WriteLine($"Our starting point / homepage is {homepage}");
            }
            public void Visit(string url)
            {
                if (index == history.Count() - 1)
                {
                    history.Add(url);
                    index++;
                    Console.WriteLine($"We visited {url}");
                    Console.WriteLine(String.Join(",", history));
                    return;
                }
                int diff = history.Count() - 1 - index;
                history.RemoveRange(index + 1, diff);
                history.Add(url);
                index++;
                Console.WriteLine($"We visited {url}");
                Console.WriteLine(String.Join(",", history));
            }
            public string Back(int steps)
            {
                index -= steps;
                if (index < 0)
                    index = 0;

                Console.WriteLine($"Our backwards visit is {history[index]}");
                Console.WriteLine(String.Join(",", history));
                return history[index];
            }
            public string Forward(int steps)
            {
                index += steps;
                if (index >= history.Count())
                    index = history.Count() - 1;

                Console.WriteLine($"Our forwards visit is {history[index]}");
                Console.WriteLine(String.Join(",", history));
                return history[index];
            }
        }
    }
}
