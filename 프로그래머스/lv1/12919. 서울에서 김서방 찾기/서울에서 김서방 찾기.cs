public class Solution {
    public string solution(string[] seoul) {
			string answer = "";

			int index = -1;
			for ( int i = 0; i < seoul.Length; i++)
			{
				if ( seoul[i].Equals("Kim"))
				{
					index = i;
					break;
				}
			}

			if (index != -1)
			{
				answer = "김서방은 " + index + "에 있다";
			}

			return answer;
    }
}