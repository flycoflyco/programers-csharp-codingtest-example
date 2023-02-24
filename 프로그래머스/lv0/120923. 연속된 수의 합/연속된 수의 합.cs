using System;

public class Solution {
    public int[] solution(int num, int total) 
    {
			int[] answer = new int[num];
			int startNum = (total - ((num - 1) * (1 + (num - 1))) / 2) / num;
			for (int i = 0; i < answer.Length; i++)
			{
				answer[i] = startNum + i;
			}
			return answer;
    }
}