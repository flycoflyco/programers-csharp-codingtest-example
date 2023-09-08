using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            long[] dp = new long[102];
            dp[1] = 1;
            dp[2] = 1;
            dp[3] = 1;
            dp[4] = 2;
            StringBuilder sb = new StringBuilder();
            int inputCaseNum = int.Parse(Console.ReadLine());
            for ( int i = 0; i < inputCaseNum; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 5 || dp[num] != 0)
                {
                    sb.AppendLine(dp[num].ToString());
                    continue;
                }
                else
                {
                    for (int j = 5; j <= num; j++)
                    {
                        dp[j] = dp[j - 2] + dp[j - 3];
                    }
                    sb.AppendLine(dp[num].ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
