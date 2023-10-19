using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int aNum = 0;
            int bNum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if ( ch == 'A')
                    aNum++;
                else
                    bNum++;
            }
            if (aNum > bNum)
                Console.WriteLine("A");
            else if (aNum < bNum)
                Console.WriteLine("B");
            else
                Console.WriteLine("Tie");
        }
    }
}