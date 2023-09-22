using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private static long[] arr;
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string numStr = Console.ReadLine();
            string[] numStrSplit = numStr.Split(' '); // 


            arr = new long[input];

            // O(n) / O(n)
            for ( int i = 0; i < numStrSplit.Length; i++)
            {
                long num = long.Parse(numStrSplit[i]);
                arr[i] = num;
            }

            // O(n) / O(2n)
            arr = arr.Distinct().ToArray().OrderBy(x => x).ToArray();

            // O(n) / O(4n)
            Dictionary<long, int> temp = new Dictionary<long, int>();
            for ( int i = 0; i < arr.Length; i++)
            {
                temp.Add(arr[i], i);
            }

            // O(n) / O(5n)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numStrSplit.Length; i++)
            {
                long num = long.Parse(numStrSplit[i]);
                sb.Append(temp[num].ToString() + " ");

            }
            Console.WriteLine(sb.ToString());
        }
    }
}