using System;

public class Solution {
    public int solution(string my_string) {
			int answer = 0;
			string numStr = string.Empty;
			for (int i = 0; i < my_string.Length; i++)
			{
				char ch = my_string[i];
				if ( 47 < ch  && ch < 58)
				{
					// 숫자인 경우
					numStr += ch;
				}
				else
				{
					// 숫자가 아닌경우
					if (!string.IsNullOrEmpty(numStr))
					{
						// 비어있지 않는다면
						answer += Convert.ToInt32(numStr);
						numStr = string.Empty;
					}
				}

				if (i == my_string.Length-1)
				{
					// 숫자가 아닌경우
					if (!string.IsNullOrEmpty(numStr))
					{
						// 비어있지 않는다면
						answer += Convert.ToInt32(numStr);
					}
				}
			}

			return answer;
    }
}