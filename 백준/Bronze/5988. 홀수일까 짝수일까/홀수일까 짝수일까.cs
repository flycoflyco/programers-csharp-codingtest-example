using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for ( int i = 0; i < n; i++ ) 
            {
                string k = Console.ReadLine();
                int num = int.Parse(k[k.Length-1].ToString());
                if (num % 2 == 0)
                    Console.WriteLine("even");
                else
                    Console.WriteLine("odd");

            }
        }
    }
}