using System;

public class Solution {
    public int solution(int[,] dots) {
			int answer = 0;

			int a = dots.Length;

			int baseX = dots[0, 0];
			int baseY = dots[0, 1];

			int width = 0;
			int height = 0;

			// 가로, 세로 길이 찾기
			for (int i = 1; i < dots.GetLength(0); i++)
			{
				if ( baseX == dots[i,0] )
				{
					// 세로길이
					height = Math.Abs(dots[i, 1] - baseY);
				}

				if ( baseY == dots[i,1])
				{
					// 가로 길이
					width = Math.Abs(dots[i, 0] - baseX);
				}
			}

			answer = width * height;

			return answer;
    }
}