using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        public static long inventory;
        public static void Main(string[] args)
        {
            string cmdLine = Console.ReadLine();
            string[] cmdLineSplit = cmdLine.Split(' ');
            int row = int.Parse(cmdLineSplit[0]);
            int col = int.Parse(cmdLineSplit[1]);
            inventory = long.Parse(cmdLineSplit[2]);

            int[,] arr = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                string rowCmd = Console.ReadLine();
                string[] rowSplit = rowCmd.Split(' ');
                for (int j = 0; j < rowSplit.Length; j++)
                {
                    arr[i, j] = int.Parse(rowSplit[j]);
                }
            }

            List<Tuple<int, int>> timeElev = new List<Tuple<int, int>>();
            for (int i = 0; i <= 256; i++)
            {
                int workTime = GetWorkTime(arr, i);
                if (workTime != -1)
                {
                    Tuple<int, int> item = new Tuple<int, int>(workTime, i);
                    timeElev.Add(item);
                }
            }
            timeElev = timeElev.OrderBy(t => t.Item1).ThenByDescending(t => t.Item2).ToList();
            Console.WriteLine(timeElev[0].Item1.ToString() + " " + timeElev[0].Item2.ToString());
        }

        public static int GetWorkTime(int[,] arr, int destEle)
        {
            int time = 0;
            long tempInventory = inventory;

            #region 이전 코드
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (arr[i, j] > destEle)
            //        {
            //            long gap = (long)(arr[i, j] - destEle);
            //            tempInventory += gap;
            //            time += (int)(2 * gap);
            //        }
            //        else if (arr[i, j] < destEle)
            //        {
            //            long gap = (long)(destEle - arr[i, j]);
            //            if (tempInventory >= gap)
            //            {
            //                tempInventory -= gap;
            //                time += (int)gap;
            //            }
            //            else
            //            {
            //                return -1;
            //            }
            //        }
            //    }
            //}
            #endregion
            // 이전 코드는 배열을 순차적으로 돌아서 쌓고싶어도 모자른 곳 만나자마자 죽어버림
            // 다른 곳에서 가져올 수 있게끔 변경필요

            // 깎기 먼저 진행
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > destEle)
                    {
                        long gap = (long)(arr[i, j] - destEle);
                        tempInventory += gap;
                        time += (int)(2 * gap);
                    }
                }
            }

            // 쌓기 진행
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < destEle)
                    {
                        long gap = (long)(destEle - arr[i, j]);
                        if (tempInventory >= gap)
                        {
                            tempInventory -= gap;
                            time += (int)gap;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
            return time;
        }
    }
}