using System;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nStr = Console.ReadLine();
            string nArrStr = Console.ReadLine();
            string[] nArrStrSplits = nArrStr.Split(' ');
            int[] nArr = Array.ConvertAll(nArrStrSplits, (x) => int.Parse(x));

            string mStr = Console.ReadLine();
            int m = int.Parse(mStr);
            string mArrStr = Console.ReadLine();
            string[] mArrStrSplits = mArrStr.Split(' ');
            int[] mArr = Array.ConvertAll(mArrStrSplits, (x) => int.Parse(x));

            StringBuilder sb = new StringBuilder(m);
            for (int i = 0; i < m; i++)
            {
                if (nArr.Contains(mArr[i]))
                    sb.AppendLine("1");
                else
                    sb.AppendLine("0");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}