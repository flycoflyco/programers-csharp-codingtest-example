using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        public static int[] arr;
        public static int[] zeroArr;
        public static int[] oneArr;
        public static int zeroCount;
        public static int oneCount;

        public static void Main(string[] args)
        {
            arr = new int[41];
            zeroArr = new int[41];
            oneArr = new int[41];
            StringBuilder sb = new StringBuilder();
            int testCaseNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCaseNum; i++)
            {
                int input = int.Parse(Console.ReadLine());
                int result = fibonacci(input);
                sb.Append(zeroArr[input]);
                sb.Append(" ");
                sb.Append(oneArr[input] + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
        public static int fibonacci(int n)
        {
            if (n == 0)
            {
                zeroArr[0] = 1;
                return 0;
            }
            else if (n == 1)
            {
                oneArr[1] = 1;
                return 1;
            }
            else
            {
                if (arr[n] != 0)
                {
                    return arr[n];
                }
                else
                {
                    int temp = fibonacci(n - 1) + fibonacci(n - 2);
                    arr[n] = temp;
                    zeroArr[n] = zeroArr[n - 1] + zeroArr[n - 2];
                    oneArr[n] = oneArr[n - 1] + oneArr[n - 2];
                    return temp;
                }
            }

        }
    }
}