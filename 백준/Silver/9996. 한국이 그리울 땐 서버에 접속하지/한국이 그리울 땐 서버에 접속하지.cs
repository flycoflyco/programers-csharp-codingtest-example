using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string lineNumStr = Console.ReadLine();
            int lineNum = Convert.ToInt32(lineNumStr);

            string regexStr = Console.ReadLine();
            //  @$"^{regexStr.Replace("*", ".*")}$"
            Regex regex = new Regex($"^{regexStr.Replace("*", ".*")}$");
            //string[] regexStrSplit = regexStr.Split('*');
            //regexStr = "(^" + regexStrSplit[0] + ".*" + "$" + regexStrSplit[1] + ")";

            //Regex regex = new Regex(regexStr);

            string[] answerArr = new string[lineNum];
            for (int i = 0; i < lineNum; i++)
            {
                string cmdStr = Console.ReadLine();
                if (regex.IsMatch(cmdStr))
                    answerArr[i] = "DA";
                else
                    answerArr[i] = "NE";
            }

            for (int i = 0; i < answerArr.Length; i++)
            {
                Console.WriteLine(answerArr[i]);
            }
        }
    }
}
