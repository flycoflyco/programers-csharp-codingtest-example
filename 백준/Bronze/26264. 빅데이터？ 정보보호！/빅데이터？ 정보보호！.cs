using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string inputStr = Console.ReadLine();

            int bigdataCnt = 0;
            int securityCnt = 0;

            inputStr = inputStr.Replace("bigdata", "@");
            inputStr = inputStr.Replace("security", "!");

            for ( int i = 0; i < inputStr.Length; i++)
            {
                char ch = inputStr[i];
                if ( ch == '@')
                    bigdataCnt++;
                else
                    securityCnt++;

            }

            if (bigdataCnt > securityCnt)
                Console.WriteLine("bigdata?");
            else if (bigdataCnt < securityCnt)
                Console.WriteLine("security!");
            else
                Console.WriteLine("bigdata? security!");


        }
    }
}