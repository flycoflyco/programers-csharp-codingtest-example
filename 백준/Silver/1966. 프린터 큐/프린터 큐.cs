using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < testCase; i++)
            {
                Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
                //문서 개수와 알고 싶은 문서 받기
                string cmd = Console.ReadLine();
                string[] nmStr = cmd.Split(' ');
                int n = int.Parse(nmStr[0]);
                int m = int.Parse(nmStr[1]);

                // 중요도 queue 에 삽입
                string importStr = Console.ReadLine();
                string[] importStrSplit = importStr.Split(' ');
                for (int j = 0; j < importStrSplit.Length; j++)
                {
                    int import = int.Parse(importStrSplit[j]);
                    Tuple<int, int> item = new Tuple<int, int>(j, import);
                    q.Enqueue(item);
                }
                int cnt = 0;
                while (q.Count >= 0)
                {
                    Tuple<int, int> qNum = q.Dequeue();
                    if (QueueCheck(q, qNum.Item2))
                    {
                        q.Enqueue(qNum);
                    }
                    else
                    {
                        cnt++;
                        if (m == qNum.Item1)
                        {
                            sb.AppendLine(cnt.ToString());
                            break;
                        }
                    }
                }
            }
            Console.Write(sb.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="q"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool QueueCheck(Queue<Tuple<int, int>> q, int num)
        {
            bool result = false;
            foreach (Tuple<int, int> temp in q)
            {
                if (temp.Item2 > num)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}