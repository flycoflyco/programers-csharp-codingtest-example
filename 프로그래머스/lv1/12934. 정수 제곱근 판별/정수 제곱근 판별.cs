using System;
using System.Collections.Generic;
public class Solution {
		public long solution(long n)
		{
			long answer = 0;

			answer = GetRootNum(n);
			if ( answer != -1)
			{
				answer++;
				answer = answer * answer;
			}
			return answer;
		}

		public long GetRootNum(long num)
		{
			long result = -1;

			for (long i = 1; i <= num; i++)
			{
				if (num % i == 0 && (i * i) == num)
				{
					result = i;
					break;
				}
			}
			return result;
		}



		//public static long solution(long n)
		//{
		//	long answer = 0;
		//	List<long> dvs = GetDivisors(n);
		//	int count = dvs.Count;
		//	if (count % 2 == 0)
		//	{
		//		answer = -1;
		//		return answer;
		//	}

		//	long num = dvs[(dvs.Count - 1) / 2];
		//	num++;
		//	answer = num * num;
		//	return answer;
		//}

		//public static List<long> GetDivisors(long num)
		//{
		//	List<long> divisors = new List<long>();

		//	for (int i = 1; i <= num; i++)
		//	{
		//		if (num % i == 0)
		//			divisors.Add(i);
		//	}
		//	return divisors;
		//}
}