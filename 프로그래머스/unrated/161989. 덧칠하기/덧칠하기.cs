using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
			int answer = 0;

			// 칠해야 하는곳 - true, 안칠해도 되는 곳 false
			bool[] paiants = new bool[n];

			for ( int i = 0; i < section.Length; i++)
			{
				int index = section[i] - 1;
				paiants[index] = true;
			}


			for (int i = 0; i < n; i++)
			{
				if (paiants[i])
				{
					answer++;
					for ( int j = 0; j < m; j++)
					{
						if (i + j == n)
							break;

						paiants[i + j] = false;
					}
				}
			}

			return answer;
    }
}