using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        private static int zeroNum;
        private static int oneNum;
        public static void Main(string[] args)
        {
            zeroNum = 0;
            oneNum = 0;
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];

            for ( int i = 0; i < n; i++)
            {
                string lineNums = Console.ReadLine();
                string[] lineNumsSplit = lineNums.Split();
                for ( int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(lineNumsSplit[j]);
                }
            }
            SplitCheckArrary(arr);
            Console.WriteLine(zeroNum);
            Console.WriteLine(oneNum);
        }

        /// <summary>
        /// 배열을 쪼개주는 함수
        /// </summary>
        /// <param name="totalArr">쪼갤 배열</param>
        /// <param name="startRow">시작점</param>
        /// <param name="endRow"></param>
        /// <param name="startCol"></param>
        /// <param name="endCol"></param>
        /// <returns></returns>
        private static int[,] GetSplitArray (int[,] totalArr, int startRow, int endRow, int startCol, int endCol)
        {
            int[,] result = null;

            if (totalArr.GetLength(0) < endCol || totalArr.GetLength(1) < endRow)
                return null;

            if (startRow > endRow || startCol > endCol)
                return null;

            result = new int[endRow - startRow, endCol - startCol];

            int rowNum = 0;
            int colNum = 0;
            for (int i = startRow; i < endRow; i++)
            {
                colNum = 0;
                for (int j = startCol; j < endCol; j++)
                {
                    result[rowNum, colNum] = totalArr[i, j];
                    colNum++;
                }
                rowNum++;
            }
            return result;
        }

        /// <summary>
        /// 재귀 함수
        /// </summary>
        /// <param name="arr"></param>
        private static void SplitCheckArrary (int[,] arr)
        {
            int n = arr.GetLength(0);
            int checkNum = CheckArray(arr);

            if (n == 2)
            {
                // 최소 단위 인 경우
                if (checkNum == -1)
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (arr[i, j] == 1)
                                oneNum++;
                            else
                                zeroNum++;
                        }
                    }
                }
                else if (checkNum == 1)
                {
                    oneNum++;
                }
                else
                {
                    zeroNum++;
                }
            }
            else
            {
                if (checkNum == -1)
                {
                    // 배열안의 숫자가 모두 같은 숫자가 아닐경우 4분할 한다
                    n = n / 2;
                    int[,] array1 = GetSplitArray(arr, 0, n, 0, n);
                    SplitCheckArrary(array1);
                    int[,] array2 = GetSplitArray(arr, 0, n, n, n * 2);
                    SplitCheckArrary(array2);
                    int[,] array3 = GetSplitArray(arr, n, n * 2, 0, n);
                    SplitCheckArrary(array3);
                    int[,] array4 = GetSplitArray(arr, n, n * 2, n, n * 2);
                    SplitCheckArrary(array4);
                }
                else
                {
                    // 배열안의 숫자가 모두 같은 숫자인 경우
                    if (checkNum == 1)
                        oneNum++;
                    else
                        zeroNum++;
                }
            }
        }

        /// <summary>
        /// 배열안에 숫자가 모두 같은지 다른지 확인해주는 함수
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int CheckArray(int[,] arr)
        {
            int result = -1;

            bool isOnlyZero = false;
            bool isOnlyOne = false;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((isOnlyZero && arr[i,j] == 1) || (isOnlyOne && arr[i, j] == 0))
                    {
                        result = -1;
                        break; 
                    }
                    else if (arr[i, j] == 1)
                    {
                        isOnlyOne = true;
                        result = 1;
                    }
                    else if (arr[i, j] == 0)
                    {
                        isOnlyZero = true;
                        result = 0;
                    }
                }

                if (result == -1)
                    break;
            }
            return result;
        }

    }
}
