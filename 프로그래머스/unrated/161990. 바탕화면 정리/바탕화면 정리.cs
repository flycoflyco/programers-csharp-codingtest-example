using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
			int[] answer = new int[4];

			int minRow = int.MaxValue;
			int maxRow = int.MinValue;
			int minCol = int.MaxValue;
			int maxCol = int.MinValue;

			for (int i = 0; i < wallpaper.Length; i++)
			{
				string line = wallpaper[i];
				for (int j = 0; j < line.Length; j++)
				{
					char ch = line[j];

					if (ch == '#')
					{
						if (i < minRow)
							minRow = i;

						if (i > maxRow)
							maxRow = i;

						if (j < minCol)
							minCol = j;

						if (j > maxCol)
							maxCol = j;
					}
				}
			}
			answer[0] = minRow;
			answer[1] = minCol;
			answer[2] = maxRow+1;
			answer[3] = maxCol+1;

			return answer;
    }
}