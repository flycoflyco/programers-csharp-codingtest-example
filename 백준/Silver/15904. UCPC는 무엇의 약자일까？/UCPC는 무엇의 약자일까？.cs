using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			string[] inputSplit = inputStr.Split(' ');

			bool containU = false;
			bool containC1 = false;
			bool containP = false;
			bool containC2 = false;

			for ( int i = 0; i < inputSplit.Length; i++)
			{
				for (int j = 0; j < inputSplit[i].Length; j++)
				{
					if ( inputSplit[i][j] == 'U' || containU)
					{
						containU = true;
						if (inputSplit[i][j] == 'C' || containC1)
						{
							containC1 = true;
							if (inputSplit[i][j] == 'P' || containP)
							{
								containP = true;
								if (inputSplit[i][j] == 'C' || containC2)
								{
									containC2 = true;
									break;
								}
							}
						}

					}
				}
			}

			if (containU && containC1 && containP && containC2)
				Console.WriteLine("I love UCPC");
			else
				Console.WriteLine("I hate UCPC");


		}
	}
}

