using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			// row by col input
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');
			int row = Convert.ToInt32(inputSplit[0]);
			int col	= Convert.ToInt32(inputSplit[1]);

			// array
			string[,] chessPan = new string[row, col];

			// chess input
			for ( int i = 0; i < row; i++)
			{
				string line = Console.ReadLine();
				for (int j = 0; j < line.Length; j++)
				{
					char ch = line[j];
					chessPan[i, j] = ch.ToString();
				}
			}

			int minCnt = int.MaxValue;

			// 상자 이동 for 문 row
			for ( int i = 0; i <= row - 8; i++)
			{
				// 상자 이동 for 문 col
				for (int j = 0; j <= col - 8; j++)
				{

					// 함수로 빼야함
					// bw 으로 순서 체크 한번 반대로 wb 로 두번 해야함으로 함수로 
					// 중복을 피함
					int cnt = 0;
					int bStart = GetCountPaint(i, j, chessPan, true);
					int wStart = GetCountPaint(i, j, chessPan, false);

					if (bStart > wStart)
						cnt = wStart;
					else
						cnt = bStart;

					if (minCnt > cnt)
						minCnt = cnt;

				}
			}
			Console.WriteLine(minCnt);
		}


		public static int GetCountPaint(int startRow, int startCol, string[,] chessPan, bool startB)
		{
			int result = 0;

			string startStr = string.Empty;

			// 시작 문자
			if (startB)
				startStr = "B";
			else
				startStr = "W";

			for ( int i = 0; i < 8; i++ )
			{
				for ( int j = 0; j < 8; j++)
				{
					string str = chessPan[i + startRow, j + startCol];
					if (str != startStr)
					{
						result++;
					}

					// 토글
					if (startStr == "B")
						startStr = "W";
					else
						startStr = "B";
				}

				// 줄바뀜 토글
				if (startStr == "B")
					startStr = "W";
				else
					startStr = "B";
			}

			return result;
		}




	}
}


