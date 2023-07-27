using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string lineNumStr = Console.ReadLine();
            int lineNum = Convert.ToInt32(lineNumStr);
            List<string> yesNoList = new List<string>();
            for (int i = 0; i < lineNum; i++)
            {
                string cmdStr = Console.ReadLine();
                string answer = GetCheckVSP(cmdStr);
                yesNoList.Add(answer);
            }

            for (int i = 0; i < lineNum; i++)
            {
                Console.WriteLine(yesNoList[i]);
            }
        }

        private static string GetCheckVSP(string str)
        {
            Stack<char> st = new Stack<char>();
            string result = "NO";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (ch == '(')
                {
                    st.Push('(');
                }
                else
                {
                    if (st.Count != 0)
                    {
                        st.Pop();
                    }
                    else
                    {
                        result = "NO";
                        return result;
                    }
                }
            }

            if (st.Count == 0)
                result = "YES";
            else
                result = "NO";

            return result;
        }
    }
}