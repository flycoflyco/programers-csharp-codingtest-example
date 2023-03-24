using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
		public int[] solution(string[] keymap, string[] targets)
		{
			int[] answer = new int[targets.Length];

			for ( int i = 0; i < targets.Length; i++)
			{
				string target = targets[i];
				answer[i] = GetKeyboardNum(keymap, target);
			}

			return answer;
		}

		public int GetKeyboardNum(string[] keys, string target)
		{
			int result = 0;

			// int[] keyNums = Enumerable.Repeat<int>(-1, keys.Length).ToArray<int>();
			List<int> keyNums = Enumerable.Repeat<int>(-1, keys.Length).ToList();

			bool isInclude = false;

			for (int i = 0; i < target.Length; i++)
			{
				keyNums = keyNums = Enumerable.Repeat<int>(-1, keys.Length).ToList();
				char ch = target[i];

				isInclude = false;
				for ( int j = 0; j <keys.Length; j++)
				{
					if (keys[j].Contains(ch))
					{
						keyNums[j] = keys[j].IndexOf(ch) + 1;
						isInclude = true;
					}
				}

				if (!isInclude)
				{
					result = -1;
					break;
				}

				keyNums.RemoveAll(s => s == -1);

				keyNums.Sort();

				result += keyNums[0];
			}
			return result;
		}
}