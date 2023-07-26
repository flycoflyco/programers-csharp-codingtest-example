using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string mainStr = Console.ReadLine();
            string findSTr = Console.ReadLine();
            int answerCnt = 0;
            int mainCnt = 0;
            while (mainCnt < mainStr.Length)
            {
                char ch = mainStr[mainCnt];
                bool flag = true;
                for (int i = 0; i < findSTr.Length; i++)
                {
                    if (mainCnt + i >= mainStr.Length)
                    {
                        flag = false;
                        break;
                    }

                    ch = mainStr[mainCnt + i];
                    char indexCh = findSTr[i];
                    if (ch != indexCh)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    mainCnt = mainCnt + findSTr.Length;
                    answerCnt++;
                }
                else
                {
                    mainCnt++;
                }
            }
            Console.WriteLine(answerCnt);
        }
    }
}