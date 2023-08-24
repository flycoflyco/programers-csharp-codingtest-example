using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string caseNumStr = Console.ReadLine();
            string[] caseNumStrSplit = caseNumStr.Split(' ');
            int dictNum = int.Parse(caseNumStrSplit[0]);
            int findNum = int.Parse(caseNumStrSplit[1]);

            Dictionary<string, string> dict = new Dictionary<string, string>(dictNum);

            for (int i = 0; i < dictNum; i++)
            {
                string sitePass = Console.ReadLine();
                string[] sitePassSplit = sitePass.Split(' ');
                string site = sitePassSplit[0];
                string pass = sitePassSplit[1];
                dict.Add(site, pass);
            }

            // 속도제한으로 StringBuilder 사용
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < findNum; i++)
            {
                string findSite = Console.ReadLine();
                sb.AppendLine(dict[findSite]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}