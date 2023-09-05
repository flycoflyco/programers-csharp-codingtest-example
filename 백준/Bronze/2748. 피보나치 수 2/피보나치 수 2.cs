using System;

namespace ConsoleApp1
{
    class Program
    {
        public static ulong[] dp;
        public static void Main(string[] args)
        {
            dp = new ulong[91];

            dp[1] = 1;
            dp[2] = 1;

            int n = int.Parse(Console.ReadLine());

            if (n == 1 || n == 2)
            {
                Console.WriteLine("1");
                return;
            }

            for ( int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            Console.WriteLine(dp[n]);
            
        }
    }
}