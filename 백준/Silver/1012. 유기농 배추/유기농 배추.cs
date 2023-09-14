

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        public static int[,] map;
        public static bool[,] checkMap;

        public static void Main(string[] args)
        {
            int caseNum = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for ( int i = 0; i < caseNum; i++)
            {
                string mnkStr = Console.ReadLine();
                string[] mnkStrSplit = mnkStr.Split(' ');
                int m = int.Parse(mnkStrSplit[0]);
                int n = int.Parse(mnkStrSplit[1]);
                int k = int.Parse(mnkStrSplit[2]);

                map = new int[n, m];
                checkMap = new bool[n, m];
                for ( int j = 0; j < k; j++)
                {
                    string cabbageStr = Console.ReadLine();
                    string[] cabbageStrSplit = cabbageStr.Split(' ');
                    int col = int.Parse(cabbageStrSplit[0]);
                    int row = int.Parse(cabbageStrSplit[1]);
                    map[row, col] = 1;
                }
                int result = GetAnswer();
                sb.AppendLine(result.ToString());
            }
            Console.WriteLine(sb.ToString());
        }

        public static int GetAnswer()
        {
            int result = 0;

            for ( int i = 0; i < map.GetLength(0); i++)
            {
                for ( int j = 0; j < map.GetLength(1); j++)
                {
                    if ( map[i,j] == 1 && !checkMap[i,j])
                    {
                        RecursionFunc(i, j);
                        result++;
                    }
                }
            }


            return result;
        }

        public static void RecursionFunc(int i, int j)
        {
            checkMap[i, j] = true;
            if (i > 0 && !checkMap[i - 1, j] && map[i - 1, j] == 1)
            {
                // 상
                RecursionFunc(i - 1, j);
            }

            if (i + 1 < map.GetLength(0) && !checkMap[i + 1, j] && map[i + 1, j] == 1)
            {
                // 하
                RecursionFunc(i + 1, j);
            }

            if (j > 0 && !checkMap[i, j - 1] && map[i, j - 1] == 1)
            {
                // 좌
                RecursionFunc(i, j - 1);
            }

            if (j + 1 < map.GetLength(1) && !checkMap[i, j + 1] && map[i, j + 1] == 1)
            {
                // 우
                RecursionFunc(i, j + 1);
            }
        }
    }
}
