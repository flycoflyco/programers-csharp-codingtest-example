using System;

public class Solution {
    public int solution(int[] box, int n) 
    {
			int answer = 0;

			int x = box[0];
			int y = box[1];
			int z = box[2];

			if ( x >= n && y >= n && z >= n)
			{
				int xMok = x / n;
				int yMok = y / n;
				int zMok = z / n;

				answer = xMok * yMok * zMok;
			}
			else
			{
				answer = 0;
			}

			return answer;
    }
}