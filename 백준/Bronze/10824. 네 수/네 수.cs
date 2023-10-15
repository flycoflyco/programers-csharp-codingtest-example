using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');
            long num1 = long.Parse(inputSplit[0] + inputSplit[1]);
            long num2 = long.Parse(inputSplit[2] + inputSplit[3]);
            Console.WriteLine(num1 + num2);
        }
    }
}