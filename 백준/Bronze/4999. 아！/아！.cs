using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            if (input1.Length >= input2.Length)
                Console.WriteLine("go");
            else
                Console.WriteLine("no");
        }
    }
}