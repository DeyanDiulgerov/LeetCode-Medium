using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestDistanceToChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", ShortestDistanceToChar("abaa", 'b')));
            Console.WriteLine(String.Join(",", ShortestDistanceToChar("loveleetcode", 'e')));
            Console.WriteLine(String.Join(",", ShortestDistanceToChar("aaab", 'b')));
        }


        public static int[] ShortestDistanceToChar(string s, char c)
        {
            var retList = new List<int>(s.Length);
            int counter = 0;
            int secondCounter = 0;
            bool isFirstFound = false;
            bool isSecondFound = false;

            for (int i = 0; i < s.Length; i++)
            {
                counter = 0;
                secondCounter = 0;
                isSecondFound = false;
                isFirstFound = false;

                for (int j = i; j < s.Length; j++)
                {
                    if (s[j] != c)
                        counter++;
                    else
                    {
                        isFirstFound = true;
                        break;
                    }
                }

                for (int k = i; k >= 0; k--)
                {
                    if (s[k] != c)
                        secondCounter++;
                    else if (s[k] == c)
                    {
                        isSecondFound = true;
                        break;
                    }
                }
                if (isSecondFound == false)
                    retList.Add(counter);
                else if (isFirstFound == false)
                    retList.Add(secondCounter);
                else
                {
                    counter = Math.Min(counter, secondCounter);
                    retList.Add(counter);
                }
            }

            return retList.ToArray();
        }
    }
}
