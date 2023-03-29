using System.Collections.Generic;


public class Solution 
{
    public int solution(int[] d, int budget) 
    {
			int answer = 0;

			if (d.Length == 0)
				return 0;

			List<int> temp = new List<int>(d);

			temp.Sort();

			//// 버블 정렬
			//for (int i = 0; i < d.Length - 1; i++)
			//{
			//	for (int j = i; j < d.Length - 1; j++)
			//	{
			//		if (d[j] > d[j + 1])
			//		{
			//			int temp = d[j];
			//			d[j] = d[j + 1];
			//			d[j + 1] = temp;
			//		}
			//	}
			//}

			//for (int i = 0; i < d.Length; i++)
			//{
			//	if (budget >= d[i])
			//	{
			//		budget = budget - d[i];
			//		answer = answer + 1;
			//	}
			//	else
			//	{
			//		break;
			//	}
			//}

			for (int i = 0; i <temp.Count;i++)
			{
				if (budget >= temp[i])
				{
					budget = budget - temp[i];
					answer = answer + 1;
				}
				else
				{
					break;
				}
			}

			

			return answer;

    }
}