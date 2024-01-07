using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluateReversePolishNotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvaluateReversePolishNotation(new string[] { "2", "1", "+", "3", "*" }));
            Console.WriteLine(EvaluateReversePolishNotation(new string[] { "4", "13", "5", "/", "+" }));
            Console.WriteLine(EvaluateReversePolishNotation(new string[]
            { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }));
        }
        
        public static int EvaluateReversePolishNotation(string[] tokens)
        {
            var stack = new Stack<int>();
            var validOperators = new List<string>()
            { "+", "-", "*", "/" };

            for (int i = 0; i < tokens.Length; i++)
            {
                if (validOperators.Contains(tokens[i]))
                {
                    var first = stack.Pop();
                    var second = stack.Pop();

                    if (tokens[i] == "+")
                        stack.Push((second + first));
                    else if (tokens[i] == "-")
                        stack.Push(second - first);
                    else if (tokens[i] == "*")
                        stack.Push(second * first);
                    else if (tokens[i] == "/")
                        stack.Push(second / first);
                }
                else
                    stack.Push(int.Parse(tokens[i]));
                //Console.WriteLine(String.Join(",", stack.Reverse()));
            }
            return stack.First();
        }
    }
}
