using System;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			string inputStr = Console.ReadLine();
			int input = Convert.ToInt32(inputStr);

			int mokFive = 0;
			int mokTwo = 0;
			int marginFive = 0;
			int result = -1;

			mokFive = input / 5;
			marginFive = input % 5;
			if (marginFive == 0)
			{
				result = mokFive;
			}
			else
			{
				if (marginFive % 2 == 0)
				{
					mokTwo = marginFive / 2;
				}
				else
				{
					while (mokFive != 0)
					{
						if (mokFive != 0)
						{
							mokFive--;
							marginFive += 5;
							if (marginFive % 2 == 0)
							{
								mokTwo += marginFive / 2;
								break;
							}
						}
						else
						{
							break;
						}
					}
				}
			}


			if (mokFive == 0 && mokTwo == 0)
			{
				result = -1;
			}
			else
			{
				result = mokFive + mokTwo;
			}
			Console.WriteLine(result);



		}

	}
}


