using System;

public class Solution {
    public int solution(string t, string p) {
			int answer = 0;

			long indexNum = Convert.ToInt64(p);
			for ( int i = 0; i < t.Length; i++)
			{
				string temp = string.Empty;

				if (i == (t.Length - p.Length + 1))
					break;

				for (int j = i; j < p.Length+i; j++)
				{
					temp += t[j];
				}
				long num = Convert.ToInt64(temp);
				if (num <= indexNum)
				{
					answer++;
				}
			}

			return answer;
    }
}