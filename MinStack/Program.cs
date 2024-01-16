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
            MinStack stack = new MinStack();
            stack.Push(0);
            stack.Push(1);
            stack.Push(0);
            stack.GetMin();
            stack.Pop();
            stack.GetMin();
        }
        public class MinStack
        {
            Stack<int> allData;
            Stack<int> minStack;
            public MinStack()
            {
                allData = new Stack<int>();
                minStack = new Stack<int>();
            }

            public void Push(int val)
            {
                if (minStack.Count() == 0 || minStack.Peek() >= val)
                    minStack.Push(val);

                allData.Push(val);
            }
            public void Pop()
            {
                if (minStack.Peek() == allData.Peek())
                    minStack.Pop();

                allData.Pop();
            }
            public int Top()
            {
                Console.WriteLine(allData.Peek());
                return allData.Peek();
            }
            public int GetMin()
            {
                Console.WriteLine(minStack.Peek());
                return minStack.Peek();
            }
        }
    }
}
