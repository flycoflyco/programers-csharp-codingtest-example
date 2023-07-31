using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nStr = Console.ReadLine();
            string[] nStrSplit = nStr.Split(' ');
            int sum = 0;
            for (int i = 0; i < nStrSplit.Length; i++)
            {
                int temp = Convert.ToInt32(nStrSplit[i]);
                int tempSum = temp * temp;
                sum += tempSum;
            }
            int result = sum % 10;
            Console.WriteLine(result);
        }

    }
}