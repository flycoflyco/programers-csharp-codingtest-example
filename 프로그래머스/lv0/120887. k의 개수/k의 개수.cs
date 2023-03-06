using System;

public class Solution {
    public int solution(int i, int j, int k) {
			int answer = 0;

			for (int n = i; n <= j; n++)
			{
				string nStr = n.ToString();
				foreach (char c in nStr)
				{
					if ( k == Convert.ToInt32(c.ToString()))
					{
						answer++;
					}
				}
			}

			return answer;
    }
}