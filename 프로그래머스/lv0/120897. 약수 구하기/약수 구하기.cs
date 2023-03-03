using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
			int[] answer = new int[] { };
			List<int> answerList = new List<int>();

			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
				{
					answerList.Add(i);
				}
			}
			answer = answerList.ToArray();

			return answer;
    }
}