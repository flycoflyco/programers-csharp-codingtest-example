using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int caseNum = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < caseNum; j++)
            {
                Dictionary<string, int> dict = new Dictionary<string, int>();
                int allClothes = int.Parse(Console.ReadLine());
                List<int> tempList = new List<int>();
                List<string> keyNames = new List<string>();
                for (int i = 0; i < allClothes; i++)
                {
                    string partsAndClothes = Console.ReadLine();
                    string[] partsAndClothesSplit = partsAndClothes.Split(' ');
                    string parts = partsAndClothesSplit[1];
                    if (!dict.ContainsKey(parts))
                    {
                        dict.Add(parts, 1);
                        keyNames.Add(parts);
                    }
                    else
                    {
                        dict[parts]++;
                    }
                }
                int resultNum = 1;
                foreach (string keyindex in dict.Keys)
                {
                    resultNum *= (dict[keyindex] + 1);
                }
                resultNum--;
                sb.AppendLine(resultNum.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}