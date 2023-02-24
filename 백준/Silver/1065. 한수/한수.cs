using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumStr = Console.ReadLine();
            int inputNum = Convert.ToInt32(inputNumStr);
            int cnt = 0;
            for ( int i = 1; i <= inputNum; i++)
            {
                if (IsHanNumber(i))
                    cnt++;
            }
            Console.WriteLine(cnt.ToString());
        }
        private static bool IsHanNumber(int inputNum)
        {
            bool result = false;
            if (inputNum < 100)
            {
                result = true;
            }
            else
            {
                bool flag = true;
                int[] numStr = GetIntArray(inputNum);
                int currGap = int.MinValue;
                int nextGap = int.MinValue;
                for (int i = 0; i < numStr.Length-1; i++)
                {
                    int currNum = numStr[i];
                    int nextNum = numStr[i+1];

                    currGap = nextNum - currNum;
                    if (nextGap!=int.MinValue)
                    {
                        if (currGap != nextGap)
                        {
                            result = false;
                            flag = false;
                        }
                    }
                    nextGap = currGap;
                }
                if (flag)
                {
                    result = true;
                }
                
            }
            return result;
        }
        public static int[] GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
    }
}
