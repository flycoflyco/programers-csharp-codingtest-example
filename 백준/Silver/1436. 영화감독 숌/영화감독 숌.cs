using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			int input = Convert.ToInt32(inputStr);

			int index = 0;
			int cnt = 0;
			while(true)
			{
				index++;
				string indexStr = index.ToString();
				if (indexStr.Contains("666"))
				{
					cnt++;
				}

				if (cnt == input)
					break;
			}

			Console.WriteLine(index);

		}
	}
}

