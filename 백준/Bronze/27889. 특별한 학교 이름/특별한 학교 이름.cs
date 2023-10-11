using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string result = string.Empty;
            if (inputStr == "NLCS")
            {
                result = "North London Collegiate School";
            }
            else if (inputStr == "BHA")
            {
                result = "Branksome Hall Asia";
            }
            else if (inputStr == "KIS")
            {
                result = "Korea International School";
            }
            else if (inputStr == "SJA")
            {
                result = "St. Johnsbury Academy";
            }
            Console.WriteLine(result);
        }
    }
}