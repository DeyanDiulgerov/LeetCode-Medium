using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfLongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfLongestIncreasingSubsequence(new int[] { 4, 6, 7, 7 }));
            Console.WriteLine(NumberOfLongestIncreasingSubsequence(new int[] { 1, 2, 4, 3, 5, 4, 7, 2 }));
            Console.WriteLine(NumberOfLongestIncreasingSubsequence(new int[] { 1, 3, 5, 4, 7 }));
            Console.WriteLine(NumberOfLongestIncreasingSubsequence(new int[] { 2, 2, 2, 2, 2 }));
        }

        public static int NumberOfLongestIncreasingSubsequence(int[] nums)
        {
            var n = nums.Length;
            var dp = new int[n][];
            dp[0] = new[] { 1, 1 };
            var maxLen = 1;
            for (int i = 1; i < n; i++)
            {
                dp[i] = new int[2];
                int currLen = 0;
                int currSum = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        if (currLen < dp[j][0])
                        {
                            currLen = dp[j][0];
                            currSum = dp[j][1];
                        }
                        else if (currLen == dp[j][0])
                        {
                            currSum += dp[j][1];
                        }
                    }
                }

                currLen++;
                dp[i][0] = currLen;
                dp[i][1] = currSum;
                maxLen = Math.Max(maxLen, currLen);
            }

            return dp.Sum(v => v[0] == maxLen ? v[1] : 0);
        }
    }
}
