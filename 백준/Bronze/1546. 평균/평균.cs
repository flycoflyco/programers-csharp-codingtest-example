using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayCnt = 1000;
            string CntNumStr = Console.ReadLine();
            float[] scoreArray = new float[arrayCnt];

            int CntNum = int.Parse(CntNumStr);
            float MaxNum = -1;
            float fakeSum = 0;

            string input_string = Console.ReadLine();
            string[] packets = input_string.Split(' ');
            for (int i = 0; i < CntNum; i++)
            {
                float indexScore = float.Parse(packets[i]);
                scoreArray[i] = indexScore;
                if (MaxNum < indexScore)
                {
                    MaxNum = indexScore;
                }
            }

            for (int i = 0; i < CntNum; i++)
            {
                float indexScore = scoreArray[i];
                float indexFakeScore = (indexScore) / (MaxNum) * 100f;
                fakeSum = fakeSum + indexFakeScore;
            }
            Console.WriteLine((fakeSum / CntNum));
        }
    }
}
