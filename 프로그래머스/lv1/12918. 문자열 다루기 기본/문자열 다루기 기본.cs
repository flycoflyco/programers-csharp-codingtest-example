public class Solution {
    public bool solution(string s) {
			bool answer = false;

			if (s.Length != 4 && s.Length != 6)
				return answer;

			bool flag = true;
			
			for (int i = 0; i < s.Length; i++)
			{
				char ch = s[i];
				int value = 0;
				if ( !int.TryParse(ch.ToString(), out value))
				{
					flag = false;
					break;
				}
			}

			if (flag)
				answer = true;
			else
				answer = false;

			return answer;
    }
}