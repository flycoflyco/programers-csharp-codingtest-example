using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');

			int a = Convert.ToInt32(inputSplit[0]);
			int b = Convert.ToInt32(inputSplit[1]);
			int v = Convert.ToInt32(inputSplit[2]);

			int cnt = 0;

			if ((v - a) % (a - b) == 0)
			{
				cnt = (v - a) / (a - b);
			}
			else
			{
				cnt = (v - a) / (a - b);
				cnt++;
			}
			cnt++;


			Console.WriteLine(cnt);


		}
	}
}

