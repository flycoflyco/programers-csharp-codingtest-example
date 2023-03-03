using System;

public class Solution {
    public string solution(string cipher, int code)
    {
			string answer = "";
			
			for (int i = 0; i < cipher.Length; i++)
			{
				char ch = cipher[i];
				if ( (i+1) % code == 0)
					answer += ch;
			}

			return answer;
    }
}