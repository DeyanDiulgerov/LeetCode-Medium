using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTheStudentsByTheirKthScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input1 = new int[][]
            {
                new int[] { 10, 6, 9, 1 },
                new int[] {7,5,11,2 },
                new int[] {4,8,3,15 },
            };

            int[][] input2 = new int[][]
            {
                new int[] {3,4 },
                new int[] {5,6},
            };

            var result1 = SortTheStudentsByTheirKthScore(input1, 2);
            var result2 = SortTheStudentsByTheirKthScore(input2, 0);

            foreach (var item in result1)
                Console.Write($"[{String.Join(",", item)}]");

            Console.WriteLine($"\n-------------------------------------------");

            foreach (var item in result2)
                Console.Write($"[{String.Join(",", item)}]");

            Console.WriteLine($"\n-------------------------------------------");
        }

        public static int[][] SortTheStudentsByTheirKthScore(int[][] score, int k)
        {
            var studentAndExam = new Dictionary<int, int>();
            var studentAndAllTheirScores = new Dictionary<int, List<int>>();
            var result = new List<IList<int>>();

            for (int student = 0; student < score.Length; student++)
            {
                var newList = new List<int>();

                for (int exam = 0; exam < score[student].Length; exam++)
                {
                    if (exam == k)
                        studentAndExam.Add(student, score[student][k]);

                    newList.Add(score[student][exam]);
                }

                studentAndAllTheirScores.Add(student, newList);
            }

            foreach (var kvp in studentAndExam.OrderByDescending(x => x.Value))
            {
                var newList = new List<int>();
                var ourStudent = studentAndAllTheirScores.FirstOrDefault(x => x.Key == kvp.Key);

                if (studentAndAllTheirScores.Any(x => x.Key == kvp.Key))
                    result.Add(ourStudent.Value);
            }

            var returnArr = new int[result.Count()][];

            for (int i = 0; i < result.Count(); i++)
                returnArr[i] = result[i].ToArray();

            return returnArr;
        }
    }
}
