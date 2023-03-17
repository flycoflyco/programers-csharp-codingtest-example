using System;
public class Solution {
    public string solution(string s, int n) {
			string answer = "";

			for (int i = 0; i < s.Length; i++)
			{
				char ch = s[i];
				if (ch == ' ')
				{
					answer += ch.ToString();
				}
				else
				{
					int chNum = Convert.ToInt32(ch);
					if ( 64 < ch && ch < 91)
					{
						// 대문자
						if (chNum + n > 90)
							chNum = ((chNum + n) - 90) + 64;
						else
							chNum = chNum + n;

						answer += Convert.ToChar(chNum);
					}
					else
					{
						// 소문자
						if (chNum + n > 122)
							chNum = ((chNum + n) - 122) + 96;
						else
							chNum = chNum + n;

						answer += Convert.ToChar(chNum);
					}
				}
			}

			return answer;
    }
}