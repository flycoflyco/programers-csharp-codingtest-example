using System;

namespace Programers_codetest_example
{
	public  class Program
	{
		public static void Main()
		{
			int cnt = 0;
			string inputByStr = Console.ReadLine();
			int inputNum = Convert.ToInt32(inputByStr);

			string inputNumsStr = Console.ReadLine();
			string[] inputNumsSplit = inputNumsStr.Split(' ');

			for ( int i = 0; i < inputNumsSplit.Length; i++)
			{
				int indexNum = Convert.ToInt32(inputNumsSplit[i]);
				bool temp = IsJustOneNum(indexNum);
				if ( temp )
					cnt++;
			}
			Console.WriteLine(cnt);

		}

		public static bool IsJustOneNum (int num)
		{
			bool result = false;
			int cnt = 0;
			for (int i = 1; i <= num; i++)
			{
				if (num % i  == 0 )
				{
					cnt++;
					if (cnt > 2)
					{
						result = false;
						break;
					}
				}
			}
			if (cnt == 2)
				result = true;

			return result;
		}


	}
}
