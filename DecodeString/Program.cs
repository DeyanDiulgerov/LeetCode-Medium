using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecodeString("100[leetcode]"));
            Console.WriteLine(DecodeString("3[a]2[bc]"));
            Console.WriteLine(DecodeString("3[a2[c]]"));
            Console.WriteLine(DecodeString("2[abc]3[cd]ef"));
        }
        public static string DecodeString(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ']')
                {
                    string forPrint = "";
                    while (stack.Count() > 0 && stack.Peek() != '[')
                        forPrint += stack.Pop();
                    forPrint = String.Join("", forPrint.Reverse());

                    stack.Pop();//== '['
                    string count = "";
                    while (stack.Count() > 0 && char.IsDigit(stack.Peek()))
                        count += stack.Pop();
                    count = String.Join("", count.Reverse());

                    for (int j = 0; j < int.Parse(count); j++)
                        foreach (char letter in forPrint)
                            stack.Push(letter);
                }
                else
                    stack.Push(s[i]);
            }
            return String.Join("", stack.Reverse());
        }
    }
}
