using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxTheConfusionOfAnExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxTheConfusionOfAnExam("TTFF", 2));
            Console.WriteLine(MaxTheConfusionOfAnExam("TFFT", 1));
            Console.WriteLine(MaxTheConfusionOfAnExam("TTFTTFTT", 1));
        }

        public static int MaxTheConfusionOfAnExam(string answerKey, int k)
        {
            var tQueue = new Queue<int>();
            var fQueue = new Queue<int>();
            int tLeft = -1;
            int fLeft = -1;
            int result = 0;

            for (int right = 0; right < answerKey.Length; right++)
            {
                if (answerKey[right] == 'T')
                {
                    tQueue.Enqueue(right);
                    if (tQueue.Count > k)
                        tLeft = tQueue.Dequeue();
                }
                else
                {
                    fQueue.Enqueue(right);
                    if (fQueue.Count > k)
                        fLeft = fQueue.Dequeue();
                }
                result = Math.Max(result, right - tLeft);
                result = Math.Max(result, right - fLeft);
            }

            return result;
        }
    }
}
