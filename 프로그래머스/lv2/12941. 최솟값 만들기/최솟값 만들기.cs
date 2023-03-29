public class Solution {
		public int solution(int[] A, int[] B)
		{
			int answer = 0;
			int length = A.Length; // 길이가 같은 A, B 배열
			Sort(A, true);
			Sort(B, false);
			for ( int i = 0; i < length; i++)
			{
				answer += A[i] * B[i];
			}
			return answer;
		}

		public void Sort(int[] arr, bool isAsc)
		{
			for (int i = 0; i < arr.Length-1; i++)
			{
				for (int j = 0; j < arr.Length-1; j++)
				{
					if (isAsc)
					{
						if (arr[j] > arr[j + 1])
						{
							int temp = arr[j];
							arr[j] = arr[j + 1];
							arr[j + 1] = temp;
						}
					}
					else
					{
						if (arr[j] < arr[j + 1])
						{
							int temp = arr[j];
							arr[j] = arr[j + 1];
							arr[j + 1] = temp;
						}
					}
				}
			}
		}
}