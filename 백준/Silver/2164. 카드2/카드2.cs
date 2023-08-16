using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Queue<int> q = new Queue<int>();
            int i = 0;
            for (i = 1; i <= num; i++)
                q.Enqueue(i);

            i = 0;
            while (q.Count > 1)
            {
                if (i % 2 == 0)
                {
                    q.Dequeue();
                }
                else
                {
                    int temp = q.Dequeue();
                    q.Enqueue(temp);
                }
                i++;
            }

            Console.WriteLine(q.Dequeue().ToString());


        }
    }
}