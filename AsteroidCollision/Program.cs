using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidCollision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", AsteroidCollision(new int[] { 7, -1, 2, -3, -6, -6, -6, 4, 10, 2 })));
            Console.WriteLine(String.Join(",", AsteroidCollision(new int[] { 1, 2, 1, -1 })));
            Console.WriteLine(String.Join(",", AsteroidCollision(new int[] { 1, 2, 1, -2 })));
            Console.WriteLine(String.Join(",", AsteroidCollision(new int[] { 1, 1, 1, -2 })));
            Console.WriteLine(String.Join(",", AsteroidCollision(new int[] { -2, -1, 2, -1 })));
            Console.WriteLine(String.Join(",", AsteroidCollision(new int[] { -2, -2, 2, -2 })));
            Console.WriteLine(String.Join(",", AsteroidCollision(new int[] { -2, -2, 1, -1 })));
            Console.WriteLine(String.Join(",", AsteroidCollision(new int[] { -2, -2, 1, -2 })));
            Console.WriteLine(String.Join(",", AsteroidCollision(new int[] { -2, -1, 1, 2 })));
            Console.WriteLine(String.Join(",", AsteroidCollision(new int[] { 10, 2, -5 })));
            Console.WriteLine(String.Join(",", AsteroidCollision(new int[] { 5, 10, -5 })));
            Console.WriteLine(String.Join(",", AsteroidCollision(new int[] { 8, -8 })));
        }
        // Stack
        public static int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();

            foreach (int asteroid in asteroids)
            {
                if (asteroid > 0)
                {
                    stack.Push(asteroid);
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroid))
                        stack.Pop();

                    if (stack.Count == 0 || stack.Peek() < 0)
                        stack.Push(asteroid);
                    else if (stack.Peek() == Math.Abs(asteroid))
                        stack.Pop();
                }
            }

            int[] result = new int[stack.Count];
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }

            return result;
        }
        //Brute-force
        public static int[] AsteroidCollision(int[] asteroids)
        {
            var listed = new List<int>(asteroids);
            for (int i = 0; i < listed.Count(); i++)
            {
                if (listed[i] < 0 && i != 0)
                {
                    if (listed[i - 1] > 0)
                    {
                        if (-listed[i] > listed[i - 1])
                            listed.RemoveAt(i - 1);
                        else if (-listed[i] < listed[i - 1])
                            listed.RemoveAt(i);
                        else// they are equal
                        {
                            listed.RemoveAt(i);
                            listed.RemoveAt(i - 1);
                        }

                        i = -1;
                    }
                }
            }
            return listed.ToArray();
        }
    }
}
