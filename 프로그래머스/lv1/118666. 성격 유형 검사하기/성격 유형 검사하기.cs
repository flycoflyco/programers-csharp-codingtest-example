using System.Collections.Generic;

public class Solution {
		public string solution(string[] survey, int[] choices)
		{
			string answer = "";
			Dictionary<char, int> pairs = new Dictionary<char, int>();

			pairs.Add('R', 0);
			pairs.Add('T', 0);
			pairs.Add('C', 0);
			pairs.Add('F', 0);
			pairs.Add('J', 0);
			pairs.Add('M', 0);
			pairs.Add('A', 0);
			pairs.Add('N', 0);

			for ( int i = 0; i < survey.Length; i++)
			{
				string surv = survey[i];
				int chNum = choices[i];

				int typeNum = 0;
				int score = 0;

				if (chNum < 4)
					typeNum = 0;
				else if ( chNum > 4)
					typeNum = 1;
				else
					continue;

				score = GetScore(chNum);
				pairs[surv[typeNum]] += score;
			}

			if (pairs['R'] >= pairs['T'])
				answer += 'R';
			else
				answer += 'T';


			if (pairs['C'] >= pairs['F'])
				answer += 'C';
			else
				answer += 'F';


			if (pairs['J'] >= pairs['M'])
				answer += 'J';
			else
				answer += 'M';


			if (pairs['A'] >= pairs['N'])
				answer += 'A';
			else
				answer += 'N';


			return answer;
		}

		public int GetScore(int chNum)
		{
			int result = 0;

			switch (chNum)
			{
				case 1:
					result = 3;
					break;
				case 2:
					result = 2;
					break;
				case 3:
					result = 1;
					break;
				case 4:
					result = 0;
					break;
				case 5:
					result = 1;
					break;
				case 6:
					result = 2;
					break;
				case 7:
					result = 3;
					break;
			}

			return result;
		}
}