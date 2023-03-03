using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string before, string after) {
			int answer = 1; // 만들 수 없으면 0, 만들수 있으면 1
			Dictionary<char, int> bDit = new Dictionary<char, int>();
			Dictionary<char, int> aDit = new Dictionary<char, int>();

			foreach (char ch1 in before)
			{
				if (!bDit.ContainsKey(ch1))
					bDit.Add(ch1, 1);
				else
					bDit[ch1]++;
			}

			foreach (char ch2 in after)
			{
				if (!aDit.ContainsKey(ch2))
					aDit.Add(ch2, 1);
				else
					aDit[ch2]++;
			}

			foreach (char key in bDit.Keys)
			{
				if (aDit.ContainsKey(key))
				{
					if ( aDit[key] != bDit[key])
					{
						answer = 0;
						break;
					}
				}
				else
				{
					answer = 0;
					break;
				}
			}

			return answer;
    }
}