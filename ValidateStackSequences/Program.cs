using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateStackSequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 2, 1 }));
            Console.WriteLine(ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 3, 5, 1, 2 }));
        }
        public static bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            int n = pushed.Length;//== popped.Length;
            Stack<int> stack = new Stack<int>();
            int left = 0, right = 0;
            while (left < n && right < n)
            {
                while (left < n && pushed[left] != popped[right])
                {
                    stack.Push(pushed[left]);
                    left++;
                }
                if (left >= n)
                    break;

                stack.Push(pushed[left]);
                left++;
                while (stack.Count() > 0 && stack.Peek() == popped[right])
                {
                    stack.Pop();
                    right++;
                }
            }
            return stack.Count() == 0;
        }
    }
}
