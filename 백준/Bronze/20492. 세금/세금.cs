using System;

namespace ConsoleApp1
{
    class Program
    {


        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int result1 = (input / 100) * 78;
            int result2 = (input / 1000) * 956;

            Console.WriteLine(result1 + " " + result2);
        }
    }
}