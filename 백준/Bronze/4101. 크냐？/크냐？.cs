using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int firstNum = -1;
            int secondNum = -1;
            while (firstNum != 0 && secondNum != 0)
            {
                string inputStr = Console.ReadLine();
                string[] numsSplit = inputStr.Split(' ');
                firstNum = int.Parse(numsSplit[0]);
                secondNum = int.Parse(numsSplit[1]);

                if (firstNum == 0 && secondNum == 0)
                    break;

                if (firstNum > secondNum)
                    sb.AppendLine("Yes");
                else
                    sb.AppendLine("No");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
