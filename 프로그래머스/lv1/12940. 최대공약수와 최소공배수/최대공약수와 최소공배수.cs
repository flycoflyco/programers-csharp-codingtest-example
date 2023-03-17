public class Solution {
		public int[] solution(int n, int m)
		{
			int[] answer = new int[2];
			answer[0] = GCD(n, m);
			answer[1] = LCM(n, m);
			return answer;
		}

		public int GCD(int a, int b)
		{
			if ( a < b)
			{
				int temp = a;
				a = b;
				b = temp;
			}

			while (b > 0)
			{
				int temp = a;
				a = b;
				b = temp % b;
			}
			return a;
		}


		public int LCM(int a, int b)
		{
			return a * b / GCD(a, b);
		}
}