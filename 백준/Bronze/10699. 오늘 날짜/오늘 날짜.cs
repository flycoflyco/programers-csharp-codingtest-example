using System;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string temp = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            Console.WriteLine(temp);
        }
    }
}