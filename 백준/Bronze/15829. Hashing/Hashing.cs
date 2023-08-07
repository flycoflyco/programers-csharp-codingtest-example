using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		public static void Main(string[] args)
		{
			ulong m = 1234567891;
			string numStr = Console.ReadLine();
			string str = Console.ReadLine();
			ulong sum = 0;
			for (int i = 0; i < str.Length; i++)
			{
				char ch = str[i];
				int num = (ch - 96);
				if (i == 0)
					sum = sum + (ulong)num;
				else
					sum = sum + ((ulong)num * TempA(31, i, m));
			}
			sum = sum % m;
			Console.WriteLine(sum);
		}

		/// <summary>
		/// 31의 제곱 수인 n이 50까지 가기 때문에 재귀함수와
		/// 나머지 연산자의 분배법칙을 활용하여, 31 제곱수를 작게 만들어주는 함수
		/// </summary>
		/// <param name="f">31이 들어가는 자리</param>
		/// <param name="n">제곱 수</param>
		/// <param name="m">나눈 나머지 수</param>
		/// <returns></returns>
		public static ulong TempA(ulong f, int n, ulong m)
		{
			if (n == 1)
				return f;
			else
				return ((TempA(f, n - 1, m) % m) * (TempA(f, 1, m) % m)) % m;
		}



	}
}