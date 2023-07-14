using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string numStr = Console.ReadLine();
            int num = Convert.ToInt32(numStr);
            for ( int i = 0; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(' ');
                }
                for ( int j = 0;  j < num-i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

        }
    }
}
