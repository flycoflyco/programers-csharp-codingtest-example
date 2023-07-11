using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon_2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string inputStr = Console.ReadLine();
			int input = Convert.ToInt32(inputStr);


			//int[] tipArray = new int[input];
			List<long> tipArray = new List<long>();

			for ( int i = 0; i < input; i++)
			{
				string tipStr = Console.ReadLine();
				// tipArray[i] = Convert.ToInt32(tipStr);
				tipArray.Add(Convert.ToInt64(tipStr));
			}

			tipArray.Sort();
			tipArray.Reverse();
			//for (int i = 0; i < tipArray.Length-1; i++)
			//{
			//	for ( int j = 0; j < tipArray.Length - i -1; j++)
			//	{
			//		if (tipArray[j] < tipArray[j+1])
			//		{
			//			int temp = tipArray[j];
			//			tipArray[j] = tipArray[j + 1];
			//			tipArray[j + 1] = temp;
			//		}
			//	}
			//}

			long sum = 0;
			for ( int i = 0; i < tipArray.Count; i++)
			{
				long tip = tipArray[i] - ((i + 1) - 1);
				if (tip > 0)
					sum += tip;
			}

			Console.WriteLine(sum);
		}
	}
}
