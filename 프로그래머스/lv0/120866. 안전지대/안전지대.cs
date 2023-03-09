using System;

public class Solution {
		public int solution(int[,] board)
		{
			int answer = 0;

			

			int n = board.GetLength(0); // n * n 배열의 n

			// 위험지역을 체크하는 반복분
			for (int i = 0; i < n; i++)
			{
				for(int j = 0; j < n; j++)
				{
					int num = board[i, j];
					if (num == 1)
					{ // 지뢰를 발견 했을때,
						

						// 좌상단 부터 오른쪽으로  123 ...
						if (CheckBoundary(i - 1, j - 1, board))
							board[i - 1, j - 1] = 2;
						if (CheckBoundary(i - 1, j, board))
							board[i - 1, j] = 2;
						if (CheckBoundary(i - 1, j + 1, board))
							board[i - 1, j+1] = 2;
						if (CheckBoundary(i, j - 1, board))
							board[i, j - 1] = 2;
						if (CheckBoundary(i, j + 1, board))
							board[i, j + 1] = 2;
						if (CheckBoundary(i + 1, j - 1, board))
							board[i+1, j - 1] = 2;
						if (CheckBoundary(i + 1, j, board))
							board[i + 1, j] = 2;
						if (CheckBoundary(i + 1, j+1, board))
							board[i + 1, j+1] = 2;
					}
				}
			}



			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					int num = board[i, j];
					if (num == 0)
					{
						answer++;
					}
				}
			}

			return answer;
		}

		public bool CheckBoundary(int i, int j, int[,] board)
		{
			bool result = false;
			int n = board.GetLength(0);
			if ((0 <= i && i < n) && (0 <= j && j < n))
			{
				int num = board[i, j];
				if (num == 0)
				{
					result = true;
				}
			}
			return result;
		}
}