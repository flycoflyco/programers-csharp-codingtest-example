using System;

public class Solution {
    public string solution(string letter) 
    {
			string answer = "";

			string[] splitLetter = letter.Split(' ');

			string[] mos = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

			foreach (string indexMos in splitLetter)
			{			
				for (int i = 0; i <mos.Length; i++)
				{
					if (indexMos == mos[i])
					{
						char ch = (char)(97 + i);
						answer += ch;
					}
				}
			}
			return answer;
    }
}