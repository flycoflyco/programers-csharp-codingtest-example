using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string ringString = Console.ReadLine();
            string ringNumStr = Console.ReadLine();
            int ringNum = Convert.ToInt32(ringNumStr);

            int anserNum = 0;
            for ( int i = 0; i < ringNum; i++)
            {
                string indexRingStr = Console.ReadLine();

                if (indexRingStr.Length < ringString.Length)
                    continue;

                if (CheckRing(ringString, indexRingStr))
                    anserNum++;
            }
            Console.WriteLine(anserNum);
        }
       
        private static bool CheckRing(string reg, string ringStr)
        {
            bool result = false;

            for (int i = 0; i < ringStr.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < reg.Length; j++)
                {

                    int sumi = i+j;
                    if ( sumi > ringStr.Length-1)
                        sumi = sumi - ringStr.Length;

                    char ringCh = ringStr[sumi];
                    char regCh = reg[j];
                    if ( ringCh != regCh)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

    }
}