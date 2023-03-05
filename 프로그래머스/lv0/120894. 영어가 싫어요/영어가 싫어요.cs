using System;

public class Solution {
    public long solution(string numbers) 
    {
			long answer = 0;

			string answerStr = "";
			char prevChar;
			for (int i = 0; i < numbers.Length; i++)
			{
				char c = numbers[i];
				if (c == 'o')
				{ 
					answerStr += "1";
					i += 2;
				}
				else if (c == 't')
				{
					if (i != numbers.Length - 1)
					{
						char nextCh = numbers[i + 1];
						if(nextCh == 'w')
						{
							answerStr += "2";
							i += 2;
						}
						else if (nextCh == 'h')
						{
							answerStr += "3";
							i += 4;
						}
					}
				}
				else if (c == 'f')
				{
					if (i != numbers.Length - 1)
					{
						char nextCh = numbers[i + 1];
						if (nextCh == 'o')
						{
							answerStr += "4";
							i += 3;
						}
						else if (nextCh == 'i')
						{
							answerStr += "5";
							i += 3;
						}
					}
				}
				else if ( c == 's')
				{
					if (i != numbers.Length - 1)
					{
						char nextCh = numbers[i + 1];
						if (nextCh == 'i')
						{
							answerStr += "6";
							i += 2;
						}
						else if (nextCh == 'e')
						{
							answerStr += "7";
							i += 4;
						}
					}
				}
				else if (c == 'e')
				{
					answerStr += "8";
					i += 4;
				}
				else if (c == 'n')
				{
					answerStr += "9";
					i += 3;
				}
				else if (c == 'z')
				{
					answerStr += "0";
					i += 3;
				}
			}

			answer = Convert.ToInt64(answerStr);

			return answer;
    }
}