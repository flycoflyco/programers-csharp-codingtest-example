public class Solution {
    public int solution(int num) {
			int answer = 0;

			if (num == 1)
				return answer;

			long temp = (long)num;
			int cnt = 0;
			
			while(temp != 1)
			{
				if (temp %2 == 0)
				{
					temp = temp / 2;
				}
				else
				{
					temp = (temp * 3) + 1;
				}

				if (cnt == 500)
				{
					break;
				}
				cnt++;
			}

			if ( cnt==500)
			{
				answer = -1;
			}
			else
			{
				answer = cnt;
			}



			return answer;
    }
}