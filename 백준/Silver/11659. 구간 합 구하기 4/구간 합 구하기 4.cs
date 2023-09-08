using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string cmd = Console.ReadLine();
            string[] cmdSplit = cmd.Split(' ');
            int numCnt = int.Parse(cmdSplit[0]);
            int caseCnt = int.Parse(cmdSplit[1]);

            int[] dp = new int[numCnt+1];
            string numStr = Console.ReadLine();
            string[] numStrSplit = numStr.Split(' ');
            int sum = 0;
            for (int i = 0; i < numStrSplit.Length; i++)
            {
                int num = int.Parse(numStrSplit[i]);
                sum += num;
                if (i == 0)
                {
                    dp[i] = num;
                }

                dp[i + 1] = sum;
            }

            for (int i = 0; i < caseCnt; i++)
            {
                string cmdStr = Console.ReadLine();
                string[] cmdStrSplit = cmdStr.Split(' ');
                int startNum = int.Parse(cmdStrSplit[0]);
                int endNum = int.Parse(cmdStrSplit[1]);
                if ( startNum == 1)
                {
                    sb.AppendLine(dp[endNum].ToString());
                }
                else
                {
                    int temp = dp[endNum] - dp[startNum-1];
                    sb.AppendLine(temp.ToString());
                }
            }
            Console.WriteLine(sb.ToString());

        }
    }
}