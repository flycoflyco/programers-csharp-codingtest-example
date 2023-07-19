using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string roundNumStr = Console.ReadLine();
            int roundNum = Convert.ToInt32(roundNumStr);
            string myRSPStr = Console.ReadLine();
            string friendNumStr = Console.ReadLine();
            int friendNum = Convert.ToInt32(friendNumStr);

            int sum = 0;
            int sum_gridy = 0;

            string[] friendRSPArr = new string[friendNum];
            for (int i = 0; i < friendNum; i++)
            {
                friendRSPArr[i] = Console.ReadLine();
            }

            for ( int i = 0; i < roundNum; i++)
            {
                char myRSP = myRSPStr[i];

                int rScore = 0;
                int sScore = 0;
                int pScore = 0;

                for (int j = 0; j < friendNum; j++)
                {
                    char friendRSP = friendRSPArr[j][i];
                    int score = CheckWin(myRSP, friendRSP);
                    sum += score;

                    rScore += CheckWin('R', friendRSP);
                    sScore += CheckWin('S', friendRSP);
                    pScore += CheckWin('P', friendRSP);
                }

                if (rScore >= sScore && rScore >= pScore)
                    sum_gridy += rScore;
                else if (sScore >= rScore  && sScore >= pScore)
                    sum_gridy += sScore;
                else if (pScore >= rScore && pScore >= sScore)
                    sum_gridy += pScore;
            }

            Console.WriteLine(sum);
            Console.WriteLine(sum_gridy);

        }
        /// <summary>
        /// 첫번째 사용자에 대해서 점수 리턴
        /// </summary>
        /// <returns></returns>
        private static int CheckWin(char ch1, char ch2)
        {
            int result = 0;
            if (ch1 == 'R')
            {
                if (ch2 == 'R')
                {
                    result = 1;
                }
                else if ( ch2 == 'S')
                {
                    result = 2;
                }
                else
                {
                    result = 0;
                }
            }
            else if (ch1 == 'S')
            {
                if (ch2 == 'R')
                {
                    result = 0;
                }
                else if (ch2 == 'S')
                {
                    result = 1;
                }
                else
                {
                    result = 2;
                }
            }
            else
            {
                if (ch2 == 'R')
                {
                    result = 2;
                }
                else if (ch2 == 'S')
                {
                    result = 0;
                }
                else
                {
                    result = 1;
                }
            }
            return result;
        }
    }
}