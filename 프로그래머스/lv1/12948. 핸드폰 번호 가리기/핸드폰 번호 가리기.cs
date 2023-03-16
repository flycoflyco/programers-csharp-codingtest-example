public class Solution {
    public string solution(string phone_number) {
			string answer = "";
			int pwCnt = phone_number.Length - 4;

			for ( int i = 0; i < phone_number.Length; i++)
			{
				char ch = phone_number[i];

				if (pwCnt != 0)
				{
					answer += "*";
					pwCnt--;
				}
				else
				{
					answer += ch.ToString();
				}
			}
			return answer;
    }
}