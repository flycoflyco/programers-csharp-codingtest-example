using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int cmdNum = int.Parse(Console.ReadLine());
            LinkedList<int> deque = new LinkedList<int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cmdNum; i++)
            {
                string cmdStr = Console.ReadLine();
                string cmd = string.Empty;
                int operand = -1;
                if (cmdStr.Contains(" "))
                {
                    string[] cmdStrSplit = cmdStr.Split(' ');
                    cmd = cmdStrSplit[0];
                    operand = int.Parse(cmdStrSplit[1]);
                }
                else
                {
                    cmd = cmdStr;
                }

                if (cmd == "push_front")
                {
                    deque.AddFirst(operand);
                }
                else if (cmd == "push_back")
                {
                    deque.AddLast(operand);
                }
                else if (cmd == "pop_front")
                {
                    if (deque.Count != 0)
                    {
                        sb.AppendLine(deque.First.Value.ToString());
                        deque.RemoveFirst();
                    }
                    else
                    {
                        sb.AppendLine("-1");
                    }
                }
                else if (cmd == "pop_back")
                {
                    if (deque.Count != 0)
                    {
                        sb.AppendLine(deque.Last.Value.ToString());
                        deque.RemoveLast();
                    }
                    else
                    {
                        sb.AppendLine("-1");
                    }
                }
                else if (cmd == "size")
                {
                    sb.AppendLine(deque.Count.ToString());
                }
                else if (cmd == "empty")
                {
                    if (deque.Count != 0)
                        sb.AppendLine("0");
                    else
                        sb.AppendLine("1");
                }
                else if (cmd == "front")
                {
                    if (deque.Count != 0)
                        sb.AppendLine(deque.First.Value.ToString());
                    else
                        sb.AppendLine("-1");
                }
                else if (cmd == "back")
                {
                    if (deque.Count != 0)
                        sb.AppendLine(deque.Last.Value.ToString());
                    else
                        sb.AppendLine("-1");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}