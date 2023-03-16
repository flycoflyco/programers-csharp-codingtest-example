public class Solution {
    public int[] solution(int[] arr)
    {
			int[] answer = new int[1] { -1};
			if (arr.Length == 1)
				return answer;

			answer = new int[arr.Length - 1]; // 작은값 제거한 정답 배열

			int min = int.MaxValue;
			int minIndex = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < min)
				{
					min = arr[i];
					minIndex = i;
				}
			}


			int answerCnt = 0;

			for ( int i = 0; i < arr.Length; i++)
			{
				if (i == minIndex)
					continue;
				answer[answerCnt] = arr[i];
				answerCnt++;
			}

			return answer;
    }
}