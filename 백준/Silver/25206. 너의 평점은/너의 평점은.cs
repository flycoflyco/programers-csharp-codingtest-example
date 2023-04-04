using System;

namespace Programers_codetest_example
{
	public  class Program
	{
		public static void Main()
		{
			double sum = 0;
			double hakSum = 0;
			
			for (int i = 0; i < 20; i++)
			{
				string inputLine = Console.ReadLine();
				string[] strSplit = inputLine.Split(' ');
				double hak = Convert.ToDouble(strSplit[1]);
				string gaAvgStr = strSplit[2];
				double gaAvg = GetScore(gaAvgStr);
				if (gaAvg > 0)
				{
					sum += hak * gaAvg;
					hakSum += hak;
				}
				else if ( gaAvg == 0)
				{
					hakSum += hak;
				}
			}
			if (sum > 0)
				Console.WriteLine(sum/ hakSum);
			else
				Console.WriteLine(sum);


		}

		public static double GetScore(string scrStr)
		{
			double score;
			switch (scrStr)
			{
				case "A+":
					score = 4.5;
					break;
				case "A0":
					score = 4.0;
					break;
				case "B+":
					score = 3.5;
					break;
				case "B0":
					score  = 3.0;
					break;
				case "C+":
					score = 2.5;
					break;
				case "C0":
					score = 2.0;
					break;
				case "D+":
					score = 1.5;
					break;
				case "D0":
					score = 1.0;
					break;
				case "F":
					score = 0;
					break;
				default:
					score = -1;
					break;
			}
			return score;
		}

	}
}
