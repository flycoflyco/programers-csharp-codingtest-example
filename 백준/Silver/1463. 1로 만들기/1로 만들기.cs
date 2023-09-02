using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static long[] arr;
        public static void Main(string[] args)
        {
            arr = new long[1000001];
            int inputNum = int.Parse(Console.ReadLine());
            for (int i = 2; i <= inputNum; i++)
                FindOneNumber(i);

            Console.WriteLine(arr[inputNum]);
            int a = 0;
        }

        public static long FindOneNumber(long num)
        {
            long result = 0;

            if (num <= 1)
                return 0;

            if (arr[num] != 0)
                return arr[num];

            if (num % 3 == 0 && num % 2 == 0 && num != 0)
            {
                long num1 = FindOneNumber(num / 3);
                long num2 = FindOneNumber(num / 2);
                long num3 = FindOneNumber(num - 1);
                if (num1 < num2)
                {
                    if (num1 < num3)
                        result = num1;
                    else
                        result = num3;
                }
                else
                {
                    if (num2 < num3)
                        result = num2;
                    else
                        result = num3;

                }

            }
            else if (num % 3 == 0)
            {
                long num1 = FindOneNumber(num / 3);
                long num2 = FindOneNumber(num - 1);

                if (num1 < num2)
                    result = num1;
                else
                    result = num2;

            }
            else if (num % 2 == 0)
            {
                long num1 = FindOneNumber(num / 2);
                long num2 = FindOneNumber(num - 1);

                if (num1 < num2)
                    result = num1;
                else
                    result = num2;
            }
            else
            {
                result = FindOneNumber(num - 1);
            }


            result++;
            arr[num] = result;
            return result;
        }
    }
}