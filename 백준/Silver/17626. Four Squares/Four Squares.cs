

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] dp = new int[50001];

            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                dp[i] = dp[i - 1] + 1;
                for (int j = 1; j * j <= i; j++)
                {
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                }
            }

            Console.WriteLine(dp[input]);
        }
    }
}
