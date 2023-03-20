using System;

public class Solution {
    public int solution(int[,] sizes) {
			int answer = 0;
			int[] arr = new int[2] { -1, -1};


			for (int i = 0; i < sizes.GetLength(0); i++)
			{
				if ( sizes[i, 0] < sizes[i, 1])
				{
					int temp = sizes[i, 0];
					sizes[i, 0] = sizes[i, 1];
					sizes[i, 1] = temp;
				}


				if ( sizes[i,0] <= arr[0] && sizes[i, 1] <= arr[1])
				{
					continue;
				}
				else
				{
					if ( sizes[i,1] <= arr[0] && sizes[i,0] <= arr[1])
					{
						continue;
					}
					else
					{
						if (sizes[i, 0] > arr[0])
						{
							arr[0] = sizes[i, 0];
						}
							
						if (sizes[i, 1] > arr[1])
						{
							arr[1] = sizes[i, 1];
						}
					}
				}
			}
			answer = arr[0] * arr[1];
			return answer;
    }
}