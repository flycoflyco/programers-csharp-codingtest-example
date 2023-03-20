using System.Linq;
public class Solution {
		public int solution(int n)
		{
			int answer = 0;
			//int max = n;
			//bool[] prime = Enumerable.Repeat<bool>(false, max).ToArray<bool>();

			int[] temp = Enumerable.Repeat<int>(0, n+1).ToArray<int>();
			for ( int i = 2; i<=n;i++ )
			{
				temp[i] = i;
				if (i != 2 && i % 2 == 0)
					temp[i] = 0;
			}
			for ( int i = 2; i<= n; i++)
			{
				if (temp[i] == 0)
					continue;
					
				for (int j= i+i; j <= n; j+=i)
				{
					temp[j] = 0;
				}
			}

			for (int i = 0; i < temp.Length; i++)
			{
				if (temp[i] != 0)
					answer++;
			}


			return answer;
		}
}