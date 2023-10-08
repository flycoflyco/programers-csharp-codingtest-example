
using System;

namespace ConsoleApp1
{
    class Program
    {


        public static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string[] inputStrSplit = inputStr.Split(' ');
            long n = long.Parse(inputStrSplit[0]);
            long m = long.Parse(inputStrSplit[1]);
            if ( n == m ) 
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}