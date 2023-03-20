using System.Linq;
public class Solution {
		public int solution(int n)
		{
			int answer = 0;
			bool[] temp = Enumerable.Repeat<bool>(true, n+1).ToArray<bool>();
			temp[0] = false;
			temp[1] = false;
			for ( int i = 2; i<=n;i++ )
			{
				temp[i] = true;
				if (i != 2 && i % 2 == 0)
					temp[i] = false;
			}
			for ( int i = 2; i<= n; i++)
			{
				if (!temp[i])
					continue;
					
				for (int j= i+i; j <= n; j+=i)
				{
					temp[j] = false;
				}
			}
			for (int i = 0; i < temp.Length; i++)
			{
				if (temp[i])
					answer++;
			}
			return answer;
		}
}