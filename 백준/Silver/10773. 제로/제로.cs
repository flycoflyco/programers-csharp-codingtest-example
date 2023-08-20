using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> s = new Stack<int>();
            for (int i = 0; i < num; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                if (inputNum == 0)
                    s.Pop();
                else
                    s.Push(inputNum);
            }

            int sum = 0;
            while (s.Count > 0)
            {
                sum += s.Pop();
            }
            Console.WriteLine(sum);
        }
    }
}