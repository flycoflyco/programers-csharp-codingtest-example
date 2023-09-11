

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] dp = new int[1001];
            int input = int.Parse(Console.ReadLine());
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 3;

            if (input < 4)
            {
                Console.WriteLine(dp[input]);
                return;
            }

            for ( int i = 4; i <= input; i++)
            {
                dp[i] = ((dp[i - 1] % 10007) + (dp[i - 2] % 10007)) % 10007;
            }

            Console.WriteLine(dp[input]);
        }
    }
}
