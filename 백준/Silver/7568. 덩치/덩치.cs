using System;
using System.Collections.Generic;


namespace ConsoleApp1
{

    class Program
    {

        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<Tuple<int, int, int>> temp = new List<Tuple<int, int, int>>();

            for (int i = 0; i < num; i++)
            {
                string cmdStr = Console.ReadLine();
                string[] cmdStrSplit = cmdStr.Split(' ');
                int weight = int.Parse(cmdStrSplit[0]);
                int height = int.Parse(cmdStrSplit[1]);
                Tuple<int, int, int> item = new Tuple<int, int, int>(weight, height, i);
                temp.Add(item);
            }

            int[] answer = new int[num];

            for (int i = 0; i < num; i++)
            {
                Tuple<int, int, int> item = temp[i];
                int orderNum = 0;
                for (int j = 0; j < num; j++)
                {
                    if (i == j)
                        continue;

                    if (item.Item1 < temp[j].Item1 && item.Item2 < temp[j].Item2)
                    {
                        orderNum++;
                    }
                }
                answer[item.Item3] = orderNum + 1;
            }


            for (int i = 0; i < answer.Length; i++)
            {
                Console.Write(answer[i]);
                if (i != answer.Length - 1)
                    Console.Write(" ");

            }
        }
    }
}
