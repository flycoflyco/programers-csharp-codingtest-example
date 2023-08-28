using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        public static int Main(string[] args)
        {
            string inputNumStr = Console.ReadLine();
            string[] inputNumStrSplit = inputNumStr.Split(' ');
            int caseNum = int.Parse(inputNumStrSplit[0]);
            int lanLineDivNumint = int.Parse(inputNumStrSplit[1]);

            ulong lanLineDivNum = (ulong)lanLineDivNumint;

            List<int> lanLineLengths = new List<int>();
            for (int i = 0; i < caseNum; i++)
            {
                int lanLineLength = int.Parse(Console.ReadLine());
                lanLineLengths.Add(lanLineLength);
            }
            int rightLegnth = lanLineLengths.Max();
            ulong rightLineCnt = GetSplitLanLineNum(lanLineLengths, rightLegnth);
            if (rightLineCnt == lanLineDivNum)
            {
                Console.WriteLine(rightLegnth);
                return 0;
            }

            int leftLength = 1;
            ulong leftLineCnt = GetSplitLanLineNum(lanLineLengths, leftLength);
            if (leftLineCnt == lanLineDivNum)
            {
                Console.WriteLine(leftLength);
                return 0;
            }
            long diff = rightLegnth - leftLength;
            while (diff > 1)
            {
                long sum = ((long)leftLength + (long)rightLegnth);

                int midLength = (int)(sum / 2);

                ulong midCnt = GetSplitLanLineNum(lanLineLengths, midLength);

                if ( midCnt < lanLineDivNum)
                    rightLegnth = midLength;
                else if (midCnt >= lanLineDivNum)
                    leftLength = midLength;

                diff = rightLegnth - leftLength;
            }
            Console.WriteLine(leftLength);
            return 0;
        }

        public static ulong GetSplitLanLineNum(List<int> arr, int num)
        {
            ulong result = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                int lan = arr[i];
                int div = lan / num;
                result = result + (ulong)div;
            }
            return result;
        }
    }
}