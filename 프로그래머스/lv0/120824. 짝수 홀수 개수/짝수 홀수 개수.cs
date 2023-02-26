using System;

public class Solution {
    public int[] solution(int[] num_list) {
			int[] answer = new int[2] { 0, 0};


			for (int i = 0; i < num_list.Length; i++)
			{
				if (num_list[i] % 2 == 0)
				{
					// 짝수일때
					answer[0]++;

				}
				else
				{
					// 홀수 일때,
					answer[1]++;
				}
			}


			return answer;
    }
}