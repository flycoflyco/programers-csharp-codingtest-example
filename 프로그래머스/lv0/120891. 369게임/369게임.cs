using System;

public class Solution {
    public int solution(int order) {
			int answer = 0;
			string msg = order.ToString();
			foreach(char ch in msg)
			{
				if (ch == '3' || ch == '6' || ch == '9')
					answer++;
			}
			return answer;
    }
}