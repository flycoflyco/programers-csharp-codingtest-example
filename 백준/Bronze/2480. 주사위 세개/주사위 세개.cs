using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			int result = 0;
			string input = Console.ReadLine();
			string[] dices = input.Split(' ');
			int[] dices_Num = new int[3] { Convert.ToInt32(dices[0]), Convert.ToInt32(dices[1]), Convert.ToInt32(dices[2])};

			if (dices_Num[0] == dices_Num[1] && dices_Num[1] == dices_Num[2])
			{
				result = 10000 + (dices_Num[0] * 1000);
			}
			else if (dices_Num[0] == dices_Num[1])
			{
				result = 1000 + (dices_Num[0] * 100);
			}
			else if (dices_Num[1] == dices_Num[2])
			{
				result = 1000 + (dices_Num[1] * 100);
			}
			else if (dices_Num[0] == dices_Num[2])
			{
				result = 1000 + (dices_Num[2] * 100);
			}
			else
			{
				int max = int.MinValue;
				for ( int i = 0; i < dices_Num.Length; i++)
				{
					if (max < dices_Num[i])
						max = dices_Num[i];
				}

				result = (max * 100);
			}

			Console.WriteLine(result);
		}
	}
}
