using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		string nmStr = Console.ReadLine();
		string[] nmSplit = nmStr.Split();
		long n = long.Parse(nmSplit[0]);
		long m = long.Parse(nmSplit[1]);
		string treeHeightStr = Console.ReadLine();
		string[] treeHeightSplit = treeHeightStr.Split();

		List<long> treeHeights = new List<long>(treeHeightSplit.Length);

		for (int i = 0; i < treeHeightSplit.Length; i++)
		{
			treeHeights.Add(long.Parse(treeHeightSplit[i]));
		}

		treeHeights.Sort((n1, n2) => n2.CompareTo(n1));

		long start = 0;
		long end = treeHeights[0];

		while (start < end)
		{
			long mid = (end - start) / 2 + start;
			long midValue = GetMarginHeight(treeHeights, mid);

			if (midValue > m)
			{
				start = mid + 1;
			}
			else if ( midValue == m)
			{
				start = mid+1;
				break;
			}
			else
			{
				end = mid;
			}
		}

		Console.WriteLine(start - 1);
	}

	private static long GetMarginHeight(List<long> treeHeights, long cutHeight)
	{
		long result = 0;
		foreach (long treeHeight in treeHeights)
		{
			if (treeHeight > cutHeight)
			{
				result += treeHeight - cutHeight;
			}
		}
		return result;
	}
}