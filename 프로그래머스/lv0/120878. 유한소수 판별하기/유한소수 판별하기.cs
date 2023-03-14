using System;
using System.Collections.Generic;

public class Solution {
		public int solution(int a, int b)
		{
			int answer = 1;

			int max = Math.Max(a, b);
			int min = Math.Min(a, b);
			int mod = max;
			
			while (mod != 0)
			{
				mod = max % min;
				
				max = min;
				min = mod;
			} // gcd = max when escape while loop

			int gcd = max;

			a = a / gcd;
			b = b / gcd;

			List<int> answerLst = new List<int>();
			int[] numList = GetAyksuList(b);
			for (int i = 0; i < numList.Length; i++)
			{
				int num = numList[i];
				if (CheckPrimeNumber(num))
				{
					answerLst.Add(num);
				}
			}

			for (int i = 0; i < answerLst.Count; i++)
			{
				if (answerLst[i] != 2 && answerLst[i] != 5)
				{
					answer = 2;
					break;
				}
			}



			return answer;
		}

		private int[] GetAyksuList(int n)
		{
			List<int> lst = new List<int>();
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
					lst.Add(i);
			}
			return lst.ToArray();
		}

		private bool CheckPrimeNumber(int n)
		{
			bool result = true;

			if (n == 1)
				return false;

			for (int i = 1; i <= n; i++)
			{
				if ((i != 1 && i != n) && (n % i == 0))
				{
					result = false;
					break;
				}
			}
			return result;
		}
}