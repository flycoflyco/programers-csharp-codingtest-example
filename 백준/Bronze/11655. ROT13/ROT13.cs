using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string originStr = Console.ReadLine();
            //List<char> chArr = new List<char>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < originStr.Length; i++)
            {
                char ch = originStr[i];
                if (('A' <= ch && ch <= 'Z'))
                {
                    if (ch + 13 > 'Z')
                    {
                        int temp = (ch + 12) - 'Z';
                        ch = (char)('A' + temp);
                    }
                    else
                    {
                        ch = (char)(ch + 13);
                    }
                }
                else if ('a' <= ch && ch <= 'z')
                {
                    if (ch + 13 > 'z')
                    {
                        int temp = (ch + 12) - 'z';
                        ch = (char)('a' + temp);
                    }
                    else
                    {
                        ch = (char)(ch + 13);
                    }
                }
                sb.Append(ch);
            }
            Console.WriteLine(sb.ToString());

        }


    }
}