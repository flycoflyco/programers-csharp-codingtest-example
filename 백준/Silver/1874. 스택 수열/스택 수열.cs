using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int caseNum = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<int> s = new Stack<int>();
            int peekNum = 1;
            for (int i = 0; i < caseNum; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (s.Count == 0 && i == 0)
                {
                    int cnt = 1;
                    do
                    {
                        s.Push(cnt);
                        sb.AppendLine("+");
                        cnt++;
                    } while (s.Peek() != num);
                    peekNum = s.Peek();
                    s.Pop();
                    sb.AppendLine("-");
                }
                else if (peekNum > num)
                {
                    while (s.Peek() == num)
                    {
                        s.Pop();
                        sb.AppendLine("-");
                        if (s.Count == 0)
                            break;
                    }
                }
                else if (peekNum < num)
                {
                    int cnt = peekNum + 1;
                    do
                    {
                        s.Push(cnt);
                        sb.AppendLine("+");
                        cnt++;
                    } while (s.Peek() != num);
                    peekNum = s.Peek();
                    s.Pop();
                    sb.AppendLine("-");
                }
                else if (peekNum == num)
                {
                    s.Push(num);
                    break;
                }
            }

            if (s.Count != 0)
                Console.WriteLine("NO");
            else
                Console.WriteLine(sb.ToString());
        }
    }
}