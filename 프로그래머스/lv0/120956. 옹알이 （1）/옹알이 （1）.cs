
using System;

public class Solution
{
	public int solution(string[] babbling)
	{
		int answer = 0;
		string[] canText = { "aya", "ye", "woo", "ma" };
		foreach (string text in babbling)
		{
			string[] splits = text.Split(canText, StringSplitOptions.None);

			int temp = 0;
			foreach (string split in splits)
				if (string.IsNullOrEmpty(split))
					temp++;

			if (temp == splits.Length) answer++;
		}
		return answer;
	}
}