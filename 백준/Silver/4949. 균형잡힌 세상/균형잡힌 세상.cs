using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> answer = new List<string>();
            
            while (true)
            {
                string cmdStr = Console.ReadLine();
                if (cmdStr == ".")
                    break;

                Stack<char> brackets = new Stack<char>();
                bool checkFlag = true;
                for ( int i = 0; i < cmdStr.Length; i++)
                {
                    char ch = cmdStr[i];
                    if ( ch == '(' || ch == '[')
                    {
                        brackets.Push(ch);
                    }
                    else if ( ch == ')')
                    {
                        if (brackets.Count == 0 || brackets.Peek() == '[')
                        {
                            checkFlag = false;
                            break;
                        }
                        else if (brackets.Peek() == '(')
                        {
                            brackets.Pop();
                        }
                    }
                    else if (ch == ']')
                    {
                        if (brackets.Count == 0 || brackets.Peek() == '(')
                        {
                            checkFlag = false;
                            break;
                        }
                        else if (brackets.Peek() == '[')
                        {
                            brackets.Pop();
                        }
                    }
                }

                if (checkFlag && brackets.Count == 0)
                    answer.Add("yes");
                else
                    answer.Add("no");
            }

            for ( int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
    }
}