using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
			int answer = 0;

			int[] student = new int[n];

			// 보통 학생
			for ( int i = 0; i < n; i++)
			{
				student[i] = 1; 
			}

			// 잃어버린 학생
			for ( int i = 0; i < lost.Length; i++)
			{
				int index = lost[i];
				student[index - 1]--;
			}

			// 여유분이 있는 학생
			for (int i = 0; i < reserve.Length; i++)
			{
				int index = reserve[i];
				student[index - 1]++;
			}

			for (int i = 0; i < n; i++)
			{
				if (student[i]==0)
				{
					bool flag = false;
					if (i-1 >= 0 && student[i - 1] == 2)
					{
						student[i - 1]--;
						student[i]++;
						flag = true;
					}

					if (i+1 <= n-1 && student[i + 1] == 2 && !flag)
					{
						student[i + 1]--;
						student[i]++;
					}
				}
			}

			for ( int i = 0; i < n; i++)
			{
				if ( student[i] > 0)
					answer++;
			}


			return answer;
    }
}