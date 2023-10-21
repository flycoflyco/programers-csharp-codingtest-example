using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> answer = new List<string>();
            for ( int i = 0; i < num; i++ ) 
            {
                string s = Console.ReadLine();
                if ( s.Length >= 6 && s.Length <= 9 ) 
                    answer.Add("yes");
                else
                    answer.Add("no");
            }

            for ( int i = 0;i < answer.Count; i++ ) 
            {
                Console.WriteLine(answer[i]);
            }
        }
    }
}