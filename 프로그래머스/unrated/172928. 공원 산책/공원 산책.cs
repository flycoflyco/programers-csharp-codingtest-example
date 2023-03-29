using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
			int[] answer = new int[2];

			int parkRow = park.Length;
			int parkCol = park[0].Length;

			bool[,] pan = new bool[parkRow, parkCol];

			int startX = 0;
			int startY = 0;

			for ( int i =0; i < park.Length; i++)
			{
				string line = park[i];
				for (int j = 0; j < line.Length; j++)
				{
					char ch = line[j];
					if (ch == 'S')
					{
						startX = i;
						startY = j;
					}

					if (ch != 'X')
						pan[i, j] = true;
					else
						pan[i, j] = false;
				}
			}

			int currentX = startX;
			int currentY = startY;

			for (int i = 0; i < routes.Length; i++)
			{
				string op = routes[i];
				string[] splits = op.Split(' ');
				string direction = splits[0];
				string moveStr = splits[1];
				int moveNum = Convert.ToInt32(moveStr);

				int tempX = currentX;
				int tempY = currentY;

				bool flag = true;
				while(moveNum > 0)
				{
					if (direction == "E")
					{
						// 공원의 범위 오른쪽으로 벗어났을때
						if (tempY+1 > parkCol-1 || !pan[tempX,tempY + 1])
						{
							flag = false;
							break;
						}
						tempY++;
						moveNum--;
					}
					else if (direction == "W")
					{
						// 공원의 범위 왼쪽으로 벗어났을때
						if (tempY - 1 < 0 || !pan[tempX, tempY - 1])
						{
							flag = false;
							break;
						}
						tempY--;
						moveNum--;
					}
					else if (direction == "S")
					{
						// 공원의 범위 아래쪽으로 벗어났을때
						if (tempX + 1 > parkRow - 1 || !pan[tempX + 1, tempY])
						{
							flag = false;
							break;
						}
						tempX++;
						moveNum--;

					}
					else if (direction == "N")
					{
						if (tempX - 1 < 0 || !pan[tempX - 1,tempY])
						{
							flag = false;
							break;
						}
						tempX--;
						moveNum--;
					}

				}

				if (flag)
				{
					currentX = tempX;
					currentY = tempY;
				}

			}

			answer[0] = currentX;
			answer[1] = currentY;


			return answer;
    }
}