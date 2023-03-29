public class Solution {
		public int solution(int n)
		{
			int answer = 0;
			ulong ans = f(n);
			answer = (int)ans;
			return answer;
		}

		//public static ulong f(ulong n)
		//{
		//	if (n <= 1)
		//		return n;
		//	else
		//		return (f(n - 2) % 1234567) + (f(n - 1) % 1234567);
		//}

		public ulong f(int n)
		{
			if (n <= 1)
				return (ulong)n;
			else
			{
				ulong result = 0;
				ulong iterA = 0, iterB = 1;

				for (int i = 2; i <= n; i++)
				{
					result = ((iterA % 1234567) + (iterB % 1234567)) % 1234567;
					iterA = (iterB % 1234567);
					iterB = result;
				}
				return result;
			}
		}
}