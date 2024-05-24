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
            Stack<int> stack = new Stack<int>();
            HashSet<string> operators = new HashSet<string>()
            {"+", "-", "*", "/"};
            foreach(string token in tokens)
            {
                //if(!"+-*/".Contains(token))
                    //stack.Push(int.Parse(token));
                if(!operators.Contains(token))
                    stack.Push(int.Parse(token));
                else
                {
                    int first = stack.Pop();
                    int second = stack.Pop();
                    if(token == "+")
                        stack.Push(second + first);
                    else if(token == "-")
                        stack.Push(second - first);
                    else if(token == "*")
                        stack.Push(second * first);
                    else if(token == "/")
                        stack.Push(second / first);
                }
            }
            return stack.First();
        }
    }
}
