using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr1 = Console.ReadLine();
			string[] inputSplit = inputStr1.Split(' ');

			int a = Convert.ToInt32(inputSplit[0]);
			int b = Convert.ToInt32(inputSplit[1]);
			int c = Convert.ToInt32(inputSplit[2]);
			int d = Convert.ToInt32(inputSplit[3]);
			int e = Convert.ToInt32(inputSplit[4]);
			int f = Convert.ToInt32(inputSplit[5]);

			int resultX = 0;
			int resultY = 0;	
			for (int i = -999; i <= 999; i++)
			{
				for (int j = -999; j <= 999; j++)
				{ 
					if ( (a*i) + (b*j) == c && (d*i) + (e*j) == f)
					{
						resultX = i;
						resultY = j;
						break;
					}
				}
			}
			Console.WriteLine(resultX.ToString() + " " + resultY.ToString());
			
		}
	}
}

