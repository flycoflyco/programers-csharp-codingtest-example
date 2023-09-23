using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string game1Str = Console.ReadLine();
            string game2Str = Console.ReadLine();
            string[] game1StrSplit = game1Str.Split(' ');
            string[] gmae2StrSplit = game2Str.Split(' ');
            int sum = 0;
            for (int i = 0; i < n; i++) 
            {
                sum += Math.Abs(int.Parse(game1StrSplit[i]));
                sum += Math.Abs(int.Parse(gmae2StrSplit[i]));
            }
            Console.WriteLine(sum);
        }
    }
}