using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int result = 0;
            string input = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++) 
            {
                string index = Console.ReadLine();
                if (index == input)
                    result++;
            }
            Console.WriteLine(result);
        }
    }
}