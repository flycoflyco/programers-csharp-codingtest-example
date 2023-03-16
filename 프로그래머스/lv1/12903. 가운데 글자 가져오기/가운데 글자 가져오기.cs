public class Solution {
    public string solution(string s) {
			string answer = "";
			int length = s.Length;
			if ( length % 2 == 0)
			{
				answer += s[(s.Length-1) / 2].ToString();
				answer += s[((s.Length - 1) / 2)+1].ToString();
			}
			else
			{
				answer = s[s.Length / 2].ToString();
			}
			return answer;
    }
}