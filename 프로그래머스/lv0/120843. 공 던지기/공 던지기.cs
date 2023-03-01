using System;

public class Solution 
{
    public int solution(int[] numbers, int k) 
    {
			int answer = 0;
			int index = -1;
			int cnt = 0;
			int ballCnt = -1;
			//bool flag = false;
			while(true)
			{
				index++;
				if (index == numbers.Length)
				{
					index = 0;
				}
				int num = numbers[index];

				if (cnt % 2 == 0)
				{
					answer = num;
					ballCnt++;
				}
				cnt++;

				if (ballCnt == k-1)
					break;
			}

			//answer = balls;

			return answer;
    }
}