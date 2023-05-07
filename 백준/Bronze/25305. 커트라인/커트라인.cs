using System;


namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');

			string scoresStr = Console.ReadLine();
			string[] scores = scoresStr.Split(' ');

			for ( int i = 0; i < scores.Length; i++ )
			{
				for (int j = 0; j < scores.Length-1 -i; j++ )
				{
					if ( Convert.ToInt32(scores[j]) < Convert.ToInt32(scores[j+1]))
					{
						string temp = scores[j];
						scores[j] = scores[j+1];
						scores[j+1] = temp;
					}
				}
			}

			int cuttline = Convert.ToInt32(inputSplit[1]);

			Console.WriteLine(scores[cuttline - 1]);


		}
	}
}

