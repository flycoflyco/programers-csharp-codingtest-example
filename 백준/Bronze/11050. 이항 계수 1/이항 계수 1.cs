using System;

namespace ConsoleApp1
{
    class Program
    {
        public static long[] memory = new long[11];
        public static void Main(string[] args)
        {
            memory[0] = 0;
            memory[1] = 1;
            for (int i = 2; i < memory.Length; i++)
                memory[i] = -1;

            string nkStr = Console.ReadLine();
            string[] nkStrSplit = nkStr.Split(' ');
            long n = Convert.ToInt64(nkStrSplit[0]);
            long k = Convert.ToInt64(nkStrSplit[1]);
            long sum = Factorial(n) / (Factorial(k) * Factorial(n - k));
            Console.WriteLine(sum);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static long Factorial(long n)
        {
            long result;
            if (n <= 1)
                result = 1;
            else
            {
                if (memory[n] == -1)
                    result = memory[n] = n * Factorial(n - 1);
                else
                    result = memory[n];
            }
            return result;
        }

    }
}