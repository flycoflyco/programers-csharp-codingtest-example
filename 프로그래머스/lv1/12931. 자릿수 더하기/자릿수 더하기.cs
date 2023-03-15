using System;

public class Solution {
    public int solution(int n) {
			int answer = 0;

			if (n < 10)
				return n;

			string nStr = n.ToString();


			for (int i = 0; i < nStr.Length; i++)
			{
				char ch = nStr[i];
				answer += Convert.ToInt32(ch.ToString());
			}
			

			return answer;
    }
}