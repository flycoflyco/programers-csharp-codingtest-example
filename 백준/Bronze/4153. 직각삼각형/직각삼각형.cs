using System.Collections.Generic;
using System.Linq;
using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> answerList = new List<string>();
            while (true)
            {
                string cmd = Console.ReadLine();
                string[] cmdSplit = cmd.Split(' ');

                if (cmdSplit[0] == "0" && cmdSplit[1] == "0" && cmdSplit[2] == "0")
                    break;

                List<int> cmdNum = new List<int> { Convert.ToInt32(cmdSplit[0]), Convert.ToInt32(cmdSplit[1]), Convert.ToInt32(cmdSplit[2]) };
                cmdNum.Sort(); // 오름차순

                int a = cmdNum[0] * cmdNum[0];
                int b = cmdNum[1] * cmdNum[1];
                int c = cmdNum[2] * cmdNum[2];

                if (a + b == c)
                    answerList.Add("right");
                else
                    answerList.Add("wrong");
            }

            for (int i = 0; i < answerList.Count; i++)
                Console.WriteLine(answerList[i]);
        }
    }
}