using System;
public class Solution {
    public string solution(string s) {
			string answer = "";

			string[] splitStr = s.Split(' ');

			for ( int i = 0; i < splitStr.Length; i++)
			{
				string sentence = splitStr[i];
				for ( int j = 0; j < sentence.Length; j++)
				{
					char ch = sentence[j];
					int chNum = Convert.ToInt32(ch);
					if ( j%2 ==  0)
					{
						// 짝수인데 소문자라면 대문자로 변경
						if (96 < ch && ch < 123)
						{
							ch = (char)(chNum - 32);
						}
					}
					else
					{
						// 홀수인데 대문자라면 소문자로 변경
						if (64 < ch && ch < 91)
						{
							ch = (char)(chNum + 32);
						}
					}
					answer += ch.ToString();
				}
				if ( i != splitStr.Length-1)
					answer += " ";
			}

			return answer;
    }
}