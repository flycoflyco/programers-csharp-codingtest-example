using System;

public class Solution {
    public int solution(int n)
    {
			int answer = 0;
			if (n == 0)
				return 0;

			int index = n;

			
			while (true)
			{
				int margin = index % 10;
				index = index / 10;
				answer = answer + margin;
				if (index == 0)
					break;
			}


			return answer;
    }
}