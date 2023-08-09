using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string lineNumStr = Console.ReadLine();
            int lineNum = Convert.ToInt32(lineNumStr);
            List<string> cmdStrArr = new List<string>();
            for (int i = 0; i < lineNum; i++)
            {
                string cmdStr = Console.ReadLine();
                if (!cmdStrArr.Contains(cmdStr))
                    cmdStrArr.Add(cmdStr);
            }
            var sort = cmdStrArr.OrderBy(s => s.Length).ThenBy(s => s).ToList();

            for (int i = 0; i < sort.Count; i++)
            {
                Console.WriteLine(sort[i]);
            }

        }
    }
}