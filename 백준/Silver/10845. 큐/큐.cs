using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string numStr = sr.ReadLine();
            int num = int.Parse(numStr);
            Queue<int> q = new Queue<int>();
            StringBuilder sb = new StringBuilder();
            int last = -1;
            for (int i = 0; i < num; i++)
            {
                string cmdStr = sr.ReadLine();
                string cmd = string.Empty;
                int operand = 0;
                if (cmdStr.Contains(" "))
                {
                    string[] cmdStrSplit = cmdStr.Split();
                    cmd = cmdStrSplit[0];
                    operand = int.Parse(cmdStrSplit[1]);
                }
                else
                {
                    cmd = cmdStr;
                }

                if (cmd == "push")
                {
                    q.Enqueue(operand);
                    last = operand;
                }
                else if (cmd == "pop")
                {
                    if (q.Count == 0)
                        sb.AppendLine("-1");
                    else
                        sb.AppendLine(q.Dequeue().ToString());
                }
                else if (cmd == "size")
                {
                    sb.AppendLine(q.Count.ToString());
                }
                else if (cmd == "empty")
                {
                    if (q.Count == 0)
                        sb.AppendLine("1");
                    else
                        sb.AppendLine("0");
                }
                else if (cmd == "front")
                {
                    if (q.Count == 0)
                        sb.AppendLine("-1");
                    else
                        sb.AppendLine(q.Peek().ToString());
                }
                else if (cmd == "back")
                {
                    if (q.Count == 0)
                        sb.AppendLine("-1");
                    else
                        sb.AppendLine(last.ToString());
                }
            }
            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}