using System;

public class Solution {
		public int solution(string A, string B)
		{
			int answer = 0;

			if (A.Equals(B))
				return 0;

			string temp = A;
			int cnt = 1;
			
			while(cnt < A.Length)
			{
				string pushStr = PushString(A, cnt);
				if (pushStr.Equals(B))
				{
					answer = cnt;
					break;
				}
				cnt++;
			}
			if (cnt == A.Length)
				answer = -1;
			//if ( )
			return answer;
		}

		public string PushString(string str, int cnt)
		{
			string result = "";
			string pushStr = str;

			if (cnt % str.Length  == 0)
				return str;

			for (int j = 0; j < cnt; j++)
			{
				char[] temp = pushStr.ToCharArray();
				char last = temp[temp.Length - 1];
				for (int i = temp.Length - 1; i >= 1; i--)
				{
					temp[i] = temp[i - 1];
				}
				temp[0] = last;

				pushStr = new string(temp);

			}
			result = pushStr;
			return result;
		}
}