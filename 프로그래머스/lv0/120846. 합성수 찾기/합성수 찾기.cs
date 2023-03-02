using System;

public class Solution {
		public int solution(int n)
		{
			int answer = 0;

			for (int i= 1; i <= n; i++)
			{
				if (GetNum(i) > 2)
				{
					answer++;
				}
			}
			return answer;
		}
		/// <summary>
		/// 약수개수 구하는 함수
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public int GetNum(int n)
		{
			int result = 0;
			for (int i = 1; i <= n; i++ )
			{
				if (n % i == 0)
					result++;
			}
			return result;
		}
}