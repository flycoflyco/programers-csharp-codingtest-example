using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp34
{
	public class Program
	{
		public static void Main()
		{
			List<int[]> cmdLine = new List<int[]>();

			while(true)
			{
				string inputStr = Console.ReadLine();
				string[] inputSplit = inputStr.Split(' ');
				if (inputSplit[0] == "0" && inputSplit[1] == "0" && inputSplit[2] == "0")
					break;

				int[] indexarr = new int[3] { Convert.ToInt32(inputSplit[0]), Convert.ToInt32(inputSplit[1]), Convert.ToInt32(inputSplit[2]) };
				cmdLine.Add(indexarr);
			}
			
			for ( int i = 0; i < cmdLine.Count; i++)
			{
				string result = string.Empty;
				int[] indexArr = cmdLine[i];
				if (indexArr[0] == indexArr[1] && indexArr[1] == indexArr[2])
					result = "Equilateral";
				else if (indexArr[0] == indexArr[1] || indexArr[1] == indexArr[2] || indexArr[0] == indexArr[2])
					result = "Isosceles";
				else
					result = "Scalene ";

				if (!CheckTriangle(indexArr))
					result = "Invalid";

				Console.WriteLine(result);
			}
			

		}
		public static bool CheckTriangle(int[] arr)
		{
			bool result = false;
			List<int> lstInt = new List<int>(arr);
			int max = lstInt.Max();
			lstInt.Remove(max);
			if (max >= lstInt[0] + lstInt[1])
				result = false;
			else
				result = true;
			return result;
		}
	}
}

