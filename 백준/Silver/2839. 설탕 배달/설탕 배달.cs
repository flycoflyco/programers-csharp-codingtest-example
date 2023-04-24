using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			int input = Convert.ToInt32(inputStr);
			int result = -1;
			int min = int.MaxValue;
			for (int i = 0; i <= input; i++)
			{
				for (int j = 0; j <= input; j++)
				{
					if ( input == (i * 3) + (j * 5))
					{
						if (min > i+j)
						{
							min = i + j;
						}
					}
				}
			}
			if (min != 0 && min != int.MaxValue)
				result = min;

			Console.WriteLine(result);
		}
	}
}

