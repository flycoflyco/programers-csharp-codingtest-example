using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            string[] inputStrSplit = inputStr.Split();
            int row = int.Parse(inputStrSplit[0]);
            int col = int.Parse(inputStrSplit[1]);

            int[,] arr = new int[row, col];

            for ( int i = 0; i < row; i++)
            {
                string inputLine = Console.ReadLine();
                for ( int j = 0; j < inputLine.Length; j++)
                {
                    arr[i, j] = int.Parse(inputLine[j].ToString());
                }
            }

            for ( int i = 0; i < arr.GetLength(0); i++)
            {
                for ( int j = arr.GetLength(1)-1; j >= 0; j-- )
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}