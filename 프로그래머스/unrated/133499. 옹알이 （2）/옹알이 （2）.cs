using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] babbling) {
			int answer = 0;
			string[] sentense = new string[] { "aya", "ye", "woo", "ma" };

			for ( int i = 0; i < babbling.Length; i++)
			{
				string bab = babbling[i];
				
				for ( int j = 0; j < sentense.Length; j++)
				{
					bab = bab.Replace(sentense[j], j.ToString());
				}

				char prev= '\0';
				bool flag = false;
				int temp = -1;
				for (int j = 0; j < bab.Length; j++)
				{
					if (!int.TryParse(bab, out temp))
					{
						flag = true;
						break;
					}

					if (j == 0)
					{
						prev = bab[j];
						continue;
					}

					if ( prev == bab[j])
					{
						flag = true;
						break;
					}
					prev = bab[j];
				}

				if (!flag)
					answer++;
			}
			return answer;
    }
}