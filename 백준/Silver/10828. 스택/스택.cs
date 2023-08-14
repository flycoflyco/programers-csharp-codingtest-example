using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string numStr = Console.ReadLine();
            int num = int.Parse(numStr);
            Stack<int> s = new Stack<int>();
            List<int> answer = new List<int>();
            for ( int i = 0; i < num; i++)
            {
                string cmdStr = Console.ReadLine();
                string cmd = string.Empty;
                int operand = 0;
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

                if ( cmd == "push")
                {
                    s.Push(operand);
                }
                else if ( cmd == "pop")
                {
                    if (s.Count == 0)
                        answer.Add(-1);
                    else
                        answer.Add(s.Pop());
                }
                else if ( cmd == "size")
                {
                    answer.Add(s.Count);
                }
                else if ( cmd == "empty")
                {
                    if ( s.Count == 0)
                        answer.Add(1);
                    else
                        answer.Add(0);
                }
                else if ( cmd == "top")
                {
                    if (s.Count == 0)
                        answer.Add(-1);
                    else
                        answer.Add(s.Peek());
                }
            }

            StringBuilder sb = new StringBuilder();
            for ( int i = 0; i < answer.Count; i++)
            {
                sb.AppendLine(answer[i].ToString());
            }
            Console.WriteLine(sb.ToString());

        }
    }
}