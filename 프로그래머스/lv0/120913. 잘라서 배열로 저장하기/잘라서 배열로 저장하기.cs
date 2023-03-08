using System;

public class Solution {
    public string[] solution(string my_str, int n) {
			int length = 0;
			int margin = (my_str.Length % n);
			int mok = (my_str.Length / n);

			if ( margin == 0)
				length = mok;
			else
				length = mok + 1;

			string[] answer = new string[length];
			int answerIndex = 0;
			string tmpString = string.Empty;
			for (int i = 0; i < my_str.Length; i++)
			{
				char ch = my_str[i];
				tmpString += ch;
				if (tmpString.Length == n || i == my_str.Length - 1)
				{
					answer[answerIndex] = tmpString;
					tmpString = string.Empty;
					answerIndex++;
				}
			}
			return answer;
    }
}