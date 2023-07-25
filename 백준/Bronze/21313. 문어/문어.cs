using System;
namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Input
            string octopusStr = Console.ReadLine();
            int octopusNum = Convert.ToInt32(octopusStr);
            #endregion

            if (octopusNum % 2 == 0)
            {
                for (int i = 0; i < octopusNum; i++)
                {
                    if (i % 2 == 0)
                        Console.Write("1");
                    else
                        Console.Write("2");

                    if (i != octopusNum - 1)
                        Console.Write(" ");
                }
            }
            else
            {
                for (int i = 0; i < octopusNum; i++)
                {
                    if (i % 2 == 0 && i != octopusNum - 1)
                        Console.Write("1");
                    else if ((i % 2 == 1) && i != octopusNum - 1)
                        Console.Write("2");
                    else if (i == octopusNum - 1)
                        Console.Write("3");

                    if (i != octopusNum - 1)
                        Console.Write(" ");
                }
            }
            int a = 0;
        }


    }
}