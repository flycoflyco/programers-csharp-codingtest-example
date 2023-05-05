using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			int cnt = 0;
			string[,] chessPan = new string[8, 8];
			for (int i = 0; i < 8; i++)
			{
				string cmdLine = Console.ReadLine();
				for (int j = 0; j < cmdLine.Length; j++)
				{
					chessPan[i, j] = cmdLine[j].ToString();
				}
			}

			// toggle == true --> white;
			bool toggle = true;

			for ( int i = 0; i < chessPan.GetLength(0); i++)
			{
				for ( int j = 0; j < chessPan.GetLength(1); j++)
				{
					if ( toggle && chessPan[i,j] == "F")
						cnt++;


					if (toggle)
						toggle = false;
					else
						toggle = true;
				}
				if (toggle)
					toggle = false;
				else
					toggle = true;
			}

			Console.WriteLine(cnt);
		}
	}
}

