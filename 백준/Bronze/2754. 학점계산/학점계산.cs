using System;

namespace ConsoleApp1
{
    class Program
    {


        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if ( input == "A+")
            {
                Console.WriteLine("4.3");
            }
            else if ( input == "A0")
            {
                Console.WriteLine("4.0");
            }
            else if ( input == "A-")
            {
                Console.WriteLine("3.7");
            }
            else if (input == "B+")
            {
                Console.WriteLine("3.3");
            }
            else if (input == "B0")
            {
                Console.WriteLine("3.0");
            }
            else if (input == "B-")
            {
                Console.WriteLine("2.7");
            }
            else if (input == "C+")
            {
                Console.WriteLine("2.3");
            }
            else if (input == "C0")
            {
                Console.WriteLine("2.0");
            }
            else if (input == "C-")
            {
                Console.WriteLine("1.7");
            }
            else if (input == "D+")
            {
                Console.WriteLine("1.3");
            }
            else if (input == "D0")
            {
                Console.WriteLine("1.0");
            }
            else if (input == "D-")
            {
                Console.WriteLine("0.7");
            }
            else
            {
                Console.WriteLine("0.0");
            }
        }
    }
}