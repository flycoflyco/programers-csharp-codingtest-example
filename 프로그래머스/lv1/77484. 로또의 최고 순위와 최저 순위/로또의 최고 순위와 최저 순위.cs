using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
			int[] answer = new int[2];
			int sameCnt = 0;
			int zeroCnt = 0;
			int lottoNum = 6;

			for ( int i = 0; i < lottoNum; i++)
			{
				int winNum = win_nums[i];
				for ( int j = 0; j < lottoNum; j++)
				{
					int minwooNum = lottos[j];
					if (winNum == minwooNum)
						sameCnt++;
				}
			}

			for ( int i = 0; i < lottoNum; i++)
			{
				int minwooNum = lottos[i];
				if (minwooNum == 0)
					zeroCnt++;
			}


			// max
			if ( zeroCnt + sameCnt == 6)
				answer[0] = 1;
			else if (zeroCnt + sameCnt == 5)
				answer[0] = 2;
			else if (zeroCnt + sameCnt == 4)
				answer[0] = 3;
			else if (zeroCnt + sameCnt == 3)
				answer[0] = 4;
			else if (zeroCnt + sameCnt == 2)
				answer[0] = 5;
			else
				answer[0] = 6;

			// min
			if (sameCnt ==  6)
				answer[1] = 1;
			else if (sameCnt == 5)
				answer[1] = 2;
			else if (sameCnt == 4)
				answer[1] = 3;
			else if (sameCnt == 3)
				answer[1] = 4;
			else if (sameCnt == 2)
				answer[1] = 5;
			else
				answer[1] = 6;


			return answer;
    }
}