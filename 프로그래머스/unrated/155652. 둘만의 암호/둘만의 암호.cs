using System;

public class Solution {
    public string solution(string s, string skip, int index) 
    {
			string answer = "";

			int currentIndex = index;
			for ( int i = 0; i < s.Length; i++)
			{
				char ch = s[i];
				currentIndex = index;
				while (currentIndex > 0)
				{
					ch = ++ch;
					if (ch > 122)
						ch = 'a';

					bool flag = false;
					for ( int j = 0; j < skip.Length; j++)
					{
						if ( ch == skip[j])
						{
							flag = true;
							break;
						}
					}

					if (!flag)
					{
						currentIndex--;
					}
				}
				answer += ch;

			}

			return answer;
    }
}