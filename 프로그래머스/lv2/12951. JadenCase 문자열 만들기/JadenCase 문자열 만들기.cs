public class Solution {
    public string solution(string s) {
			string answer = "";
			string[] splits = s.Split(' ');


			for (int i = 0; i < splits.Length; i++)
			{
				string prev_sen = splits[i];
				string next_sen = string.Empty;
				for (int j = 0; j < prev_sen.Length; j++)
				{
					char ch = prev_sen[j];
					if (j == 0)
						next_sen += char.ToUpper(ch);
					else
						next_sen += char.ToLower(ch);

				}

				if (i == splits.Length-1)
					answer += next_sen;
				else
					answer = answer + next_sen + ' ';
				
				
			}




			return answer;
    }
}