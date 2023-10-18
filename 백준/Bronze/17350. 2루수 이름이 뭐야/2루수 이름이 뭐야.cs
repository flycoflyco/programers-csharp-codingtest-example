using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isContain = false;
            for ( int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                if (name.Equals("anj"))
                    isContain = true;

            }
            if (isContain)
                Console.WriteLine("뭐야;");
            else
                Console.WriteLine("뭐야?");
        }
    }
}