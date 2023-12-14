using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifyPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimplifyPath("/a/../../b/../c//.//"));
            Console.WriteLine(SimplifyPath("/a/./b/../../c/"));
            Console.WriteLine(SimplifyPath("/home/"));
            Console.WriteLine(SimplifyPath("/../"));
            Console.WriteLine(SimplifyPath("/home//foo/"));
        }
        public static string SimplifyPath(string path)
        {
            path = path.Trim('/');
            var result = new Stack<string>();
            var splitted = path.Split('/');

            for (int i = 0; i < splitted.Length; i++)
            {
                if (splitted[i] == "." || splitted[i] == "")
                    continue;
                else if (splitted[i] == "..")
                {
                    if (result.Count() > 0)
                        result.Pop();
                }
                else
                    result.Push(splitted[i]);
            }
            return "/" + String.Join("/", result.Reverse());
        }
    }
}
