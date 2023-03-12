using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[,] score) {
            int[] answer = new int[] { };

            List<double> averageList = new List<double>();

            for ( int i = 0; i < score.GetLength(0); i++ )
			{
                if (score[i, 0] + score[i, 1] == 0)
                    averageList.Add(0);
                else
                    averageList.Add((double)(score[i, 0] + score[i, 1]) / (double)2);

                
            }
            answer = new int[averageList.Count];

            List<double> cpyList = new List<double>(averageList);
            int cnt = 0;
            int order = 1;
            int commonCnt = 0;

            List<int> commonList = new List<int>();

            while(true)
			{
                if (cnt == cpyList.Count)
				{
                    break;
				}

                commonList = new List<int>();

                double maxValue = cpyList.Max();

                for (int i = 0; i < averageList.Count; i++ )
				{
                    if (maxValue == averageList[i])
					{
                        answer[i] = order;
                        commonList.Add(i);
                    }
                }

                for (int i = 0; i < commonList.Count; i++)
				{
                    cpyList.RemoveAt(commonList[i]);
                    cpyList.Insert(commonList[i], 0);
                    order++;
                    cnt++;
				}

            }

            return answer;
    }
}