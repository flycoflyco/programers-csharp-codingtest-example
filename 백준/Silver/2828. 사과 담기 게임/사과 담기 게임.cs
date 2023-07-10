using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon_2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// n, m
			string nmStr = Console.ReadLine();
			string[] nmStrSplit = nmStr.Split(' ');
			int n = Convert.ToInt32(nmStrSplit[0]); // 스크린 크기
			int m = Convert.ToInt32(nmStrSplit[1]); // 박스 크기
			m--;

			string jStr = Console.ReadLine(); 
			int j = Convert.ToInt32(jStr); // 사과개수
			int startIndex = 1;
			int sum = 0;
			for (int i = 0; i < j; i++)
			{
				string cmdStr = Console.ReadLine();
				int cmd = Convert.ToInt32(cmdStr);
				//cmd--;
				int move = MoveBasket(startIndex, m, cmd);
				startIndex = GetStartIndex(startIndex, m, cmd);
				sum += move;
			}
			Console.WriteLine(sum);
			int a = 0;
		}

		private static int MoveBasket(int startIndex, int basketNum, int destIndex)
		{
			int result = 0;
			int endIndex = startIndex + basketNum;

			if (startIndex > destIndex)
			{
				// 박스시작보다 작다면
				result = startIndex - destIndex;
			}
			else if (startIndex <= destIndex && destIndex <= endIndex)
			{
				// 박스 안에있다면
				result = 0;
			}
			else if (endIndex < destIndex)
			{
				// 박스 끝보다 밖에 있다면
				result = destIndex - endIndex;
			}
			return result;
		}


		private static int GetStartIndex(int startIndex, int basketNum, int destIndex)
		{
			int result = startIndex;

			int endIndex = startIndex + basketNum;

			if ((startIndex > destIndex))
			{
				// 박스 시작범위 이전에 있다면
				result = destIndex;
			}
			else if (startIndex <= destIndex && destIndex <= endIndex)
			{
				// 박스 안에있다면
				result = startIndex;
			}
			else if (endIndex < destIndex)
			{
				// 박스범위 이후에 있다면
				result = destIndex - basketNum;
			}
			

			return result;
		}
	}
}
