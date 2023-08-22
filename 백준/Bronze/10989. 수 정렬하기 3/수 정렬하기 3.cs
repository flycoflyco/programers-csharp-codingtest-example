using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(Console.OpenStandardInput());
            StreamWriter writer = new StreamWriter(Console.OpenStandardOutput());
            int num = int.Parse(reader.ReadLine());
            int[] arr = new int[10001];

            for (int i = 1; i <= arr.Length-1; i++)
            {
                arr[i] = 0;
            }

            for (int i = 0; i < num; i++)
            {
                int s = int.Parse(reader.ReadLine());
                arr[s]++;
            }
            for (int i = 1; i <= arr.Length-1; i++)
            {
                for (int j = 0; j < arr[i]; j++)
                {
                    writer.WriteLine(i);
                }
            }
            reader.Close();
            writer.Close();
        }
    }
}