using System;

class Solution
{
		public int solution(int[] nums)
		{
			int answer = 0;

			//// [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
			//System.Console.WriteLine("Hello C#");

			for ( int i = 0; i < nums.Length; i++)
			{
				for ( int j = i+1; j < nums.Length; j++)
				{
					for ( int k = j+1; k < nums.Length; k++)
					{
						int temp = nums[i] + nums[j] + nums[k];
						if (IsPrimeNum(temp))
							answer++;
					}
				}
			}

			return answer;
		}

		public bool IsPrimeNum (int num)
		{
			bool result = false;

			int cnt = 0;
			for (int i = 1; i <= num; i++)
			{
				if ( num % i == 0)
				{
					cnt++;
					if (cnt == 3)
						break;
				}
			}
			if (cnt == 3)
				result = false;
			else
				result = true;

			return result;
		}
}