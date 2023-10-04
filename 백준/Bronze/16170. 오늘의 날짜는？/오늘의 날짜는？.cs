using System;

namespace ConsoleApp1
{
    class Program
    {


        public static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(string.Format("{0:yyyy}",today));
            Console.WriteLine(string.Format("{0:MM}", today));
            Console.WriteLine(string.Format("{0:dd}", today));
        }
    }
}