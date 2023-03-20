using System.Collections.Generic;

public class Solution {
    public string solution(int[] food) {
			string answer = "";
			List<int> answerList = new List<int>();
			
			for (int i = 0; i < food.Length; i++)
			{
				if (i == 0)
					continue;

				for (int j = 0; j < (food[i] / 2);j++)
				{
					answerList.Add(i);
				}
			}
			
			for (int i = 0; i < answerList.Count; i++)
			{
				answer += answerList[i].ToString();
			}
			answer += "0";
			answerList.Reverse();
			for (int i = 0; i < answerList.Count; i++)
			{
				answer += answerList[i].ToString();
			}

			return answer;
    }
}