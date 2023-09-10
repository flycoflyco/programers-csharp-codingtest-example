
using System;

namespace ConsoleApp1
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            string contents = "@WelcomeToSMUPC";
            int input = int.Parse(Console.ReadLine());
            if ( input < 14)
                Console.WriteLine(contents[input]);
            else
            {
                int temp = (input % 14);
                if ( temp == 0)
                {
                    temp=14;
                }
                Console.WriteLine(contents[temp]);
            }
                

        }
    }
}



