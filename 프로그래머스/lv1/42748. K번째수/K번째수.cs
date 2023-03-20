using System;

public class Solution {
		public int[] solution(int[] array, int[,] commands)
		{
			int cnt = commands.GetLength(0);
			int[] answer = new int[cnt];
			
			for (int i = 0; i < commands.GetLength(0); i++)
			{
				int startIndex = commands[i, 0];
				startIndex--;
				int endIndex = commands[i, 1];
				endIndex--;
				int kIndex = commands[i, 2];
				kIndex--;

				int[] splitArr = SplitArray(array, startIndex, endIndex);
				
				for (int j = 0; j < splitArr.Length-1; j++)
				{
					for (int k = 0; k < splitArr.Length-1; k++ )
					{
						if ( splitArr[k] > splitArr[k+1])
						{
							int temp = splitArr[k];
							splitArr[k] = splitArr[k + 1];
							splitArr[k + 1] = temp;
						}
					}
				}
				answer[i] = splitArr[kIndex];
			}

			return answer;
		}

		public int[] SplitArray(int[] arr, int start, int end)
		{
			int[] result = new int[end - start + 1];
			int cnt = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (start <= i &&  i <= end)
				{
					result[cnt] = arr[i];
					cnt++;
				}
			}
			return result;
		}
}