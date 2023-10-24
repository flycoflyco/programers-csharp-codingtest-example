using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length == 1)
            {
                Console.WriteLine("1");
                return;
            }
            int result = 1;
            char prev = input[0];
            for ( int i = 1; i < input.Length; i++)
            {
                char indexCh = input[i];
                if (prev == indexCh)
                    result++;
                else
                    break;
            }
            Console.WriteLine(result);
        }
    }
}