using System;

public class Solution {
		public string[] solution(string[] quiz)
		{
			string[] answer = new string[quiz.Length];
			for (int i = 0; i < quiz.Length; i++)
			{
				string quizItem = quiz[i];

				string[] splitStr = quizItem.Split('=');
				int tmpAnswerNum = 0;
				if (!int.TryParse(splitStr[1], out tmpAnswerNum))
					tmpAnswerNum = 0;

				int calcNum = GetCalculateNum(splitStr[0]);
				if (tmpAnswerNum == calcNum)
					answer[i] = "O";
				else
					answer[i] = "X";
			}
			return answer;
		}

		public int GetCalculateNum(string onlyQuiz)
		{
			int result = 0;
			string[] splitStr = onlyQuiz.Split(' ');

			if (splitStr[1] == "+")
				result = Convert.ToInt32(splitStr[0]) + Convert.ToInt32(splitStr[2]);
			else
				result = Convert.ToInt32(splitStr[0]) - Convert.ToInt32(splitStr[2]);

			return result;
		}
}