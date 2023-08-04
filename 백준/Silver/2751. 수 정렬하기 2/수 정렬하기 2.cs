using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    
    class Program
    {

        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<int> lst = new List<int>(num);
            for ( int i = 0; i < num; i++)
            {
                lst.Add(int.Parse(Console.ReadLine()));
            }
            lst.Sort();

            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < lst.Count; i++)
            {
                sb.AppendLine(lst[i].ToString());
            }
            Console.Write(sb);
        }
    }
}