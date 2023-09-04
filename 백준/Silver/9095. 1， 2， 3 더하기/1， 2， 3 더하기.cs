using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static int[] dp = null;
        public static void Main(string[] args)
        {
            dp = new int[11];
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 4;
            int input = int.Parse(Console.ReadLine());
            for ( int i = 4; i <= 10; i++ )
            {
                dp[i] = dp[i - 3] + dp[i - 2] + dp[i - 1];
            }

            StringBuilder sb = new StringBuilder();
            for ( int i = 0; i < input; i++ ) 
            { 
                int cmd = int.Parse((Console.ReadLine()));
                sb.AppendLine(dp[cmd].ToString());
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}