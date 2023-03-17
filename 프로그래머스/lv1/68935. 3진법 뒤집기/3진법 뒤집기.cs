using System;
using System.Collections.Generic;

public class Solution {
		public int solution(int n)
		{
			int answer = 0;

			int[] a = GetChangeNum(n);

			answer = GetDexNum(a);

			return answer;
		}


		public int[] GetChangeNum(int num)
		{
			List<int> list = new List<int>();
			int mok = num;
			int margin = 0;
			while(mok != 0)
			{
				margin = mok % 3;
				mok = mok / 3;
				list.Add(margin);
			}
			list.Reverse();
			return list.ToArray();
		}

		public int GetDexNum (int[] arr)
		{
			int result = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				result += arr[i] * GetPow(3, i);
			}

			return result;
		}

		public int GetPow(int num, int pow)
		{
			int result = num;
			if (pow == 0)
				return 1;
			for ( int i = 1; i < pow; i++)
			{
				result = result * num;
			}
			return result;
		}
}