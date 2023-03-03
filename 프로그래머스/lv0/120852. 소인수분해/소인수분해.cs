using System;
using System.Collections.Generic;

public class Solution {
		public int[] solution(int n)
		{
			int[] answer = new int[] { };

			List<int> answerLst = new List<int>();
			int[] numList = GetAyksuList(n);
			for(int i = 0; i < numList.Length; i++)
			{
				int num = numList[i];
				if ( CheckPrimeNumber(num))
				{
					answerLst.Add(num);
				}
			}
			answer = answerLst.ToArray();
			return answer;
		}
		private int[] GetAyksuList(int n )
		{
			List<int> lst = new List<int>();
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
					lst.Add(i);
			}
			return lst.ToArray();
		}

		private bool CheckPrimeNumber(int n )
		{
			bool result = true;

			if (n == 1)
				return false;

			for (int i = 1; i <= n; i++)
			{
				if ( (i != 1 && i !=n)  && (n % i == 0))
				{
					result = false;
					break;
				}
			}
			return result;
		}
}