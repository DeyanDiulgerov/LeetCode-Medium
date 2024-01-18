using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAStackWithIncrementOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStack customStack = new CustomStack(3);
            customStack.Push(1);
            customStack.Push(2);
            customStack.Pop();
            customStack.Push(2);
            customStack.Push(3);
            customStack.Push(4);
            customStack.Increment(5, 100);
            customStack.Increment(2, 100);
            customStack.Pop();
            customStack.Pop();
            customStack.Pop();
            customStack.Pop();
        }
        public class CustomStack
        {
            Stack<int> stack;
            int max;
            public CustomStack(int maxSize)
            {
                stack = new Stack<int>(maxSize);
                max = maxSize;
            }
            public void Push(int x)
            {
                if (stack.Count() < max)
                {
                    stack.Push(x);
                    Console.WriteLine(String.Join(",", stack));
                }
                Console.WriteLine(String.Join(",", stack));
            }
            public int Pop()
            {
                if (stack.Count() > 0)
                {
                    Console.WriteLine(String.Join(",", stack));
                    return stack.Pop();
                }
                Console.WriteLine(-1);
                return -1;
            }
            public void Increment(int k, int val)
            {
                var listed = new List<int>(stack.Reverse());

                int minLength = Math.Min(k, listed.Count());
                for (int i = 0; i < minLength; i++)
                {
                    listed[i] += val;
                }

                stack = new Stack<int>(listed);
                Console.WriteLine(String.Join(",", stack));
            }
        }
    }
}
