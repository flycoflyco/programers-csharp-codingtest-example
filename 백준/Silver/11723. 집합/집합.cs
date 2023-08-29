using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int cmdNum = int.Parse(Console.ReadLine());
            bool[] numArr = Enumerable.Repeat<bool>(false, 21).ToArray<bool>();

            // cmd 안의 check 의 개수를 알 수 없으므로
            // bool[] result = new bool[cmdNum];

            List<bool> result = new List<bool>();

            for (int i = 0; i < cmdNum; i++)
            {
                string cmdStr = Console.ReadLine();
                string[] cmdStrSplit = cmdStr.Split(' ');
                string cmd = cmdStrSplit[0];
                int num = -1;
                if (cmdStrSplit.Length > 1)
                    num = int.Parse(cmdStrSplit[1]);

                if (cmd == "add")
                {
                    numArr[num] = true;
                }
                else if (cmd == "remove")
                {
                    numArr[num] = false;
                }
                else if (cmd == "check")
                {
                    if (numArr[num])
                        result.Add(true);
                    else
                        result.Add(false);
                }
                else if (cmd == "toggle")
                {
                    if (numArr[num])
                        numArr[num] = false;
                    else
                        numArr[num] = true;
                }
                else if (cmd == "all")
                {
                    for (byte j = 0; j < numArr.Length; j++)
                        numArr[j] = true;
                }
                else if (cmd == "empty")
                {
                    for (byte j = 0; j < numArr.Length; j++)
                        numArr[j] = false;
                }
            }

            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < result.Count; i++)
            {
                if ( result[i])
                    sb.AppendLine("1");
                else
                    sb.AppendLine("0");
            }

            Console.WriteLine(sb.ToString());


        }
    }
}