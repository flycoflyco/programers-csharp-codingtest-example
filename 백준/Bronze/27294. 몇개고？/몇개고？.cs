using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string[] inputStrSplit = inputStr.Split(' ');
            int time = int.Parse(inputStrSplit[0]);
            int sul = int.Parse(inputStrSplit[1]);
            int result = 0;
            if (sul == 0)
            {
                if (time <= 11)
                {
                    // 아침
                    result = 280;
                }
                else if (12 <= time && time <= 16)
                {
                    // 점심
                    result = 320;
                }
                else
                {
                    // 저녁
                    result = 280;
                }
            }
            else
            {
                result = 280;
            }
            Console.WriteLine(result);
        }
    }
}