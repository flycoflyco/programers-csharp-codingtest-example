using System;

public class Solution {
    public int solution(int num, int k) {
			int answer = -1;
			string msg = num.ToString();
			for (int i = 0; i< msg.Length;i++ )
			{
				char ch = msg[i];
				int indexInt = Convert.ToInt32(ch.ToString());
				if (indexInt== k)
				{
					answer = i+1;
					break;
				}
			}
			return answer;
    }
}