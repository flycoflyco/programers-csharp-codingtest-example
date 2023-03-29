using System;

class Solution 
{
		public int solution(int n)
		{
			int answer = 0;

			int oneCnt = 0;
			string nTwoString = Convert.ToString(n, 2);
			oneCnt = GetOneNumber(nTwoString);

			int indexOneCnt = 0;
			int temp = 0;
			while (indexOneCnt != oneCnt)
			{
				temp = ++n;
				nTwoString = Convert.ToString(temp, 2);
				indexOneCnt = GetOneNumber(nTwoString);
			}
			answer = temp;
			return answer;
		}

		public int GetOneNumber(string str)
		{
			int result = 0;

			for (int i = 0; i < str.Length; i++)
			{
				char ch = str[i];
				if (ch == '1')
					result++;

			}

			return result;
		}
}