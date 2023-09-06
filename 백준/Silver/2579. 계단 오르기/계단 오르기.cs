using System;

namespace ConsoleApp1
{
    class Program
    {

        public static int[,] dp;
        public static int[] stairsNums;

        public static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            dp = new int[inputNum + 1, 2];
            stairsNums = new int[inputNum + 1];

            for ( int i = 1; i <= inputNum; i++)
            {
                int stairsNum = int.Parse(Console.ReadLine());
                stairsNums[i] = stairsNum;
            }

            if (inputNum == 1)
            {
                Console.WriteLine(stairsNums[inputNum].ToString());
                return;
            }

            if ( inputNum == 2)
            {
                int sum = stairsNums[1]  + stairsNums[2];
                Console.WriteLine(sum.ToString());
                return;
            }

            dp[0, 0] = 0;
            dp[0, 1] = 0;

            dp[1, 0] = stairsNums[1]; // 건너뛰어서 온곳
            dp[1, 1] = stairsNums[1]; // 연속으로 온곳

            dp[2, 0] = stairsNums[2];
            dp[2, 1] = stairsNums[1] + stairsNums[2];
            
            for ( int i = 3; i <= inputNum; i++)
            {
                int bigNum = 0;
                if (dp[i - 2, 0] > dp[i - 2, 1])
                    bigNum = dp[i - 2, 0];
                else
                    bigNum = dp[i - 2, 1];

                // 건너뛰어서 온거기 때문에 둘중에 큰걸 선택해서 쓸 수 있음
                dp[i, 0] = bigNum + stairsNums[i]; 

                // 연속으로 온거기 때문에 건너뛰어서 온곳양만 쓸수 있음
                dp[i, 1] = dp[i - 1, 0] + stairsNums[i];
            }

            if (dp[inputNum, 0] > dp[inputNum, 1])
                Console.WriteLine(dp[inputNum, 0].ToString());
            else
                Console.WriteLine(dp[inputNum, 1].ToString());
        }
        
    }
}