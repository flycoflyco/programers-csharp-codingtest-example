
using System;

namespace ConsoleApp1
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');
            long a = int.Parse(inputSplit[0]);
            long b = int.Parse(inputSplit[1]);
            Console.WriteLine(Math.Abs(a - b));
        }
    }
}




