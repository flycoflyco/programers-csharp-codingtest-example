using System;

public class Solution {
		public int solution(int n)
		{
			int cnt = 0;
			int answer = 0;
			while ( cnt < n)
			{
				answer++;
				while(CheckThree(answer))
				{
					answer++;
				}
				cnt++;
			}


			return answer;
		}

		public bool CheckThree(int n)
		{
			bool result = false;

			if (n % 3 == 0)
			{
				result = true;
				return result;
			}

			for (int i = 0; i < n.ToString().Length; i++)
			{
				char c = n.ToString()[i];
				if (c == '3')
				{
					result = true;
					break;
				}
			}

			return result;
		}
}