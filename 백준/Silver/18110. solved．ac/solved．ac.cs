using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int mok = ((num * 100) * 15) / 10000;
            int nam = ((num * 100) * 15) % 10000;

            int avgNum = mok;
            if (nam >= 5000)
                avgNum++;


            List<int> numlist = new List<int>();
            for (int i = 0; i < num; i++)
            {
                int levelNum = int.Parse(Console.ReadLine());
                numlist.Add(levelNum);
            }
            numlist.Sort();

            // 0 ~ 19
            // 0,1,2 / 17,18,19 
            int sum = 0;
            int div = 0;
            for (int i = 0; i < numlist.Count; i++)
            {
                if (i < avgNum || i > numlist.Count - 1 - avgNum)
                {
                    continue;
                }

                sum += numlist[i];
                div++;
            }

            if (div != 0)
            {
                if (sum % div == 0)
                {
                    Console.WriteLine(sum / div);
                }
                else
                {
                    int tempNam = sum % div;
                    if ((tempNam * 2) >= (div))
                        Console.WriteLine((sum / div) + 1);
                    else
                        Console.WriteLine(sum / div);
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}