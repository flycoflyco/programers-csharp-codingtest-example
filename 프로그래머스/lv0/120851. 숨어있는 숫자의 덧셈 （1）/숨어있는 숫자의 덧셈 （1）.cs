using System;

public class Solution {
    public int solution(string my_string) 
    {
			int answer = 0;

			foreach (char c in my_string)
			{
				if (c > 47 && c < 58)
				{
					int num = Convert.ToInt32(c.ToString());
					answer += num;
				}
			}
			return answer;
    }
}