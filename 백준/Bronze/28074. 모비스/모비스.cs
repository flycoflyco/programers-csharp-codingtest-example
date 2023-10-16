using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            if(inputStr.Contains("M") && inputStr.Contains("O") && inputStr.Contains("B") &&
                inputStr.Contains("I") && inputStr.Contains("S"))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}