using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public class MinStack
        {
            Stack<int> stack = null;
            Stack<int> minStack = null;
            int min = 0;
            public MinStack()
            {
                stack = new Stack<int>();
                minStack = new Stack<int>();
            }

            public void Push(int val)
            {
                if (stack.Count() == 0)
                {
                    min = val;
                }
                min = Math.Min(min, val);
                stack.Push(val);
                minStack.Push(val);
            }

            public void Pop()
            {
                stack.Pop();
                minStack.Pop();
                if (minStack.Count > 0)
                    min = minStack.Peek();
            }

            public int Top()
            {
                return stack.Peek();
            }

            public int GetMin()
            {
                return min;
            }
        }
    }
}
