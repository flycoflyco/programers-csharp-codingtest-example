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
            string[] numStrSplit = numStr.Split(' ');

            int inputNum = int.Parse(numStrSplit[0]);
            int killNum = int.Parse(numStrSplit[1]);
            List<int> resultNums = new List<int>();
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 1; i <= inputNum; i++)
            {
                list.AddLast(i);
            }

            LinkedListNode<int> node = null;
            LinkedListNode<int> nextNode = null;
            int cnt = 0;
            while (list.Count != 0)
            {
                if (resultNums.Count == 0 && cnt == 0)
                {
                    node = list.First;
                }
                else
                {
                    if (node != null && node.List != null)
                        node = NextOrFirst(node);
                    else
                        node = nextNode;

                }

                cnt++;

                if (cnt >= killNum)
                {
                    resultNums.Add(node.Value);
                    nextNode = NextOrFirst(node);
                    node.List.Remove(node);
                    cnt = 0;
                }

            }

            StringBuilder sb = new StringBuilder();
            sb.Append("<");
            for (int i = 0; i < resultNums.Count; i++)
            {
                int num = resultNums[i];
                sb.Append(num.ToString());
                if (i != resultNums.Count - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append(">");
            Console.WriteLine(sb.ToString());
        }

        private static LinkedListNode<int> NextOrFirst(LinkedListNode<int> node)
        {
            if (node.Next != null)
                node = node.Next;
            else
                node = node.List.First;
            return node;
        }
    }
}