using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    
    class Program
    {

        public static void Main(string[] args)
        {

            string nStr = Console.ReadLine();
            int n = Convert.ToInt32(nStr);
            int cnt = 0;

            for (int i = 0; i <= n; i++)
            {
                List<int> soinsuLst = new List<int>();
                int[] numList = GetAyksuList(i);

                for (int j = 0; j < numList.Length; j++)
                {
                    int num = numList[j];
                    if (CheckPrimeNumber(num))
                    {
                        soinsuLst.Add(num);
                    }
                }

                if (soinsuLst.Contains(5))
                {
                    int mok = i;
                    while (mok >= 5)
                    {
                        if (mok % 5 == 0)
                            cnt++;
                        else
                            break;
                        mok = mok / 5;
                    }
                }

            }
            Console.WriteLine(cnt);
        }

        private static int[] GetAyksuList(int n)
        {
            List<int> lst = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    lst.Add(i);
            }
            return lst.ToArray();
        }

        private static bool CheckPrimeNumber(int n)
        {
            bool result = true;

            if (n == 1)
                return false;

            for (int i = 1; i <= n; i++)
            {
                if ((i != 1 && i != n) && (n % i == 0))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}