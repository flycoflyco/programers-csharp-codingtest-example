using System;

public class Solution {
    public int solution(int n) 
    {
			int answer = 2;

			int i = 1;
			int factorNum = 0;

			while (factorNum < n)
			{
				factorNum = i * i;
				if (factorNum == n)
				{
					answer = 1;
				}
				i++;
			}

			return answer;
    }
}