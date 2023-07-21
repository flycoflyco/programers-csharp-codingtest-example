using System;
using System.Collections.Generic;
// https://www.acmicpc.net/problem/12782
namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string numStr = Console.ReadLine();
            int num = Convert.ToInt32(numStr);

            List<Tuple<char[], char[]>> cmdLst = new List<Tuple<char[], char[]>>();

            for (int i = 0; i < num; i++)
            {
                string cmdStr = Console.ReadLine();
                string[] cmdStrSplit = cmdStr.Split();
                Tuple<char[], char[]> item = new Tuple<char[], char[]>(cmdStrSplit[0].ToCharArray(), cmdStrSplit[1].ToCharArray());
                cmdLst.Add(item);
            }

            for (int i = 0; i < cmdLst.Count; i++)
            {
                Tuple<char[], char[]> item = cmdLst[i];
                int score = GetScore(item.Item1, item.Item2);
                Console.WriteLine(score);
            }

        }

        public static int GetScore(char[] arr1, char[] arr2)
        {
            int result = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                char ch1 = arr1[i];
                char ch2 = arr2[i];

                if (ch1 != ch2)
                {
                    char[] findArr = null;
                    int index = -1;
                    if (ch1 == '1')
                    {
                        findArr = arr2;
                        index = GetOneIndex(arr2, arr1, i + 1);
                    }
                    else
                    {
                        findArr = arr1;
                        index = GetOneIndex(arr1, arr2, i + 1);
                    }

                    if (index == -1)
                    {
                        findArr[i] = '1';
                        result++;
                    }
                    else
                    {
                        char temp = findArr[i];
                        findArr[i] = findArr[index];
                        findArr[index] = temp;
                        result++;
                    }
                }
            }
            return result;
        }

        public static int GetOneIndex(char[] findArr, char[] cmpArr, int start)
        {
            int result = -1;
            for (int i = start; i < findArr.Length; i++)
            {
                if (findArr[i] == '1' && cmpArr[i] != '1')
                {
                    result = i;
                    break;
                }
            }
            return result;
        }



    }
}