using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumRemoveToMakeValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumRemoveToMakeValidParentheses("())()((("));
            Console.WriteLine(MinimumRemoveToMakeValidParentheses("lee(t(c)o)de)"));
            Console.WriteLine(MinimumRemoveToMakeValidParentheses("a)b(c)d"));
            Console.WriteLine(MinimumRemoveToMakeValidParentheses("))(("));
        }
        public static string MinimumRemoveToMakeValidParentheses(string s)
        {
            List<char> splitted = s.ToCharArray().ToList();
            int leftCount = 0, rightCount = 0;
            for (int i = 0; i < splitted.Count; i++)
            {
                if (splitted[i] == '(')
                    leftCount++;
                else if (splitted[i] == ')')
                {
                    rightCount++;
                    if (leftCount < rightCount)
                    {
                        splitted[i] = '!';
                        rightCount--;
                    }
                }
            }
            for (int i = splitted.Count - 1; i >= 0; i--)
            {
                if (leftCount == rightCount)
                    break;
                if (splitted[i] == '(')
                {
                    splitted[i] = '!';
                    leftCount--;
                }
            }
            splitted.RemoveAll(x => x == '!');
            return String.Join("", splitted);
        }
    }
}
