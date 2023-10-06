using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chArr = input.ToCharArray();
            List<char> chLst = new List<char>(chArr);
            chLst.Sort((x1, x2) => x2.CompareTo(x1));
            string result = new string(chLst.ToArray());
            Console.WriteLine(result);
        }
    }
}