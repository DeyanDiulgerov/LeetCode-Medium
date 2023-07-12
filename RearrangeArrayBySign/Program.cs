using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RearrangeArrayBySign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", RearrangeArrayBySign(new int[] { 3, 1, -2, -5, 2, -4 })));
            Console.WriteLine(String.Join(",", RearrangeArrayBySign(new int[] { -1, 1 })));
        }

        public static int[] RearrangeArrayBySign(int[] nums)
        {
            var positiveQueue = new Queue<int>();
            var negativeQueue = new Queue<int>();
            var resultList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                    negativeQueue.Enqueue(nums[i]);
                else if (nums[i] > 0)
                    positiveQueue.Enqueue(nums[i]);
            }

            for (int i = 0; i < nums.Length / 2; i++)
            {
                resultList.Add(positiveQueue.Peek());
                resultList.Add(negativeQueue.Peek());

                positiveQueue.Dequeue();
                negativeQueue.Dequeue();
            }

            return resultList.ToArray();
        }
    }
}
