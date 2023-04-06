using System;



namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			int input = Convert.ToInt32(inputStr);

			int temp = 1;
			int cnt = 0;

			while (true)
			{
				temp = temp + (6 * cnt);

				if (temp >= input)
				{
					break;
				}
				cnt++;
			}
			cnt++;
			Console.WriteLine(cnt);
		}
	}
}

