using System;

public class Solution {
    public int solution(int[] numbers) {
			int answer = 0;
			int[] numArr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			for ( int i = 0; i < numArr.Length; i++)
			{
				int num = numArr[i];
				bool flag = false;
				for ( int j = 0; j < numbers.Length; j++)
				{
					if ( numbers[j] == num)
					{
						flag = true;
						break;
					}
				}

				if (!flag)
					answer += num;
			}

			return answer;
    }
}