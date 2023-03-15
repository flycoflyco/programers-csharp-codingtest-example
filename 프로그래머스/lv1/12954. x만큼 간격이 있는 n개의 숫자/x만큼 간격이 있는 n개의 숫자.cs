public class Solution {
    public long[] solution(int x, int n) {
			long[] answer = new long[n];

			int cnt = 1;
			for (int i = 0; i < n; i++)
			{
				answer[i] = (long)x * (long)cnt;
				cnt++;
			}

			return answer;
    }
}