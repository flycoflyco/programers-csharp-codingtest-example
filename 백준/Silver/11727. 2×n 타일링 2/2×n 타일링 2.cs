

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
            dp[1] = 1;
            dp[2] = 3;
            dp[3] = 5;
            int input = int.Parse(Console.ReadLine());
            if ( input < 4)
            {
                Console.WriteLine(dp[input]);
                return;
            }

            for ( int i = 4; i <= input; i++)
            {
                if (i % 2 == 0)
                    dp[i] = ((2 * dp[i - 1]) + 1) % 10007;
                else
                    dp[i] = ((2 * dp[i - 1]) - 1) % 10007;
            }

            Console.WriteLine(dp[input]);
        }
    }
}
