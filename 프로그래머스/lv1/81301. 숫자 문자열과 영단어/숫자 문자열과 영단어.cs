using System;
using System.Text;

public class Solution {
    public int solution(string s) {
			int answer = 0;
			// string answerStr = string.Empty;
			StringBuilder sb = new StringBuilder();
			for ( int i = 0; i < s.Length; i++)
			{
				char ch = s[i];
				if ( ch == 'z')
				{
					sb.Append("0");
					i += 3;
				}
				else if ( ch == 'o')
				{
					sb.Append("1");
					i += 2;
				}
				else if ( ch == 't')
				{
					if ( s[i+1] == 'w')
					{
						sb.Append("2");
						i += 2;
					}
					else
					{
						sb.Append("3");
						i += 4;
					}
				}
				else if (ch == 'f')
				{
					if (s[i + 1] == 'o')
					{
						sb.Append("4");
						i += 3;
					}
					else
					{
						sb.Append("5");
						i += 3;
					}
				}
				else if (ch == 's')
				{
					if (s[i + 1] == 'i')
					{
						sb.Append("6");
						i += 2;
					}
					else
					{
						sb.Append("7");
						i += 4;
					}
				}
				else if (ch == 'e')
				{
					sb.Append("8");
					i += 4;
				}
				else if (ch == 'n')
				{
					sb.Append("9");
					i += 3;
				}
				else
				{
					sb.Append(ch.ToString());
				}
			}

			answer = Convert.ToInt32(sb.ToString());

			return answer;
    }
}