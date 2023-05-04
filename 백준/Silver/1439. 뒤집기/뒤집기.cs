using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();


			string[] zeroLength = inputStr.Split('1');
			string[] oneLength = inputStr.Split('0');

			int zeroCnt = 0;
			for (int i = 0; i < zeroLength.Length; i++)
			{
				if (zeroLength[i].Length != 0)
					zeroCnt++;
			}

			int oneCnt = 0;
			for (int i = 0; i < oneLength.Length; i++)
			{
				if (oneLength[i].Length != 0)
					oneCnt++;
			}

			if (zeroCnt > oneCnt)
				Console.WriteLine(oneCnt);
			else
				Console.WriteLine(zeroCnt);


		}

	}
}


