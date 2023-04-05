using System;


namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			int max = int.MinValue;
			int n = -1;
			int m = -1;

			for (int i = 0; i < 9; i++)
			{
				string lineInput = Console.ReadLine();
				string[] lineSplit = lineInput.Split(' ');
				for (int j = 0; j < lineSplit.Length; j++)
				{
					int num = Convert.ToInt32(lineSplit[j]);
					if ( max < num)
					{
						n = i + 1;
						m = j + 1;
						max = num;
					}
				}
			}

			Console.WriteLine(max);
			Console.WriteLine(n.ToString()+' '+m.ToString());

		}
	}
}

