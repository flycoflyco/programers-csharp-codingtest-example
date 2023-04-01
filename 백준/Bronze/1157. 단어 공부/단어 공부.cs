using System;
using System.Collections.Generic;
using System.Linq;

namespace Programers_codetest_example
{
	internal class Program
	{
        public static void Main()
		{
			string input = Console.ReadLine();
			Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
			for (int i = 0; i < input.Length; i++)
			{
				char ch = char.ToUpper(input[i]);

				if (keyValuePairs.ContainsKey(ch))
					keyValuePairs[ch]++;
				else
					keyValuePairs.Add(ch, 1);
			}

			List<KeyValuePair<char, int>> myList = keyValuePairs.ToList();

			myList.Sort(
				delegate (KeyValuePair<char, int> pair1,
				KeyValuePair<char, int> pair2)
				{
					return pair2.Value.CompareTo(pair1.Value);
				}
			);

			int max = myList[0].Value;
			bool flag = false;
			for ( int i = 1; i < myList.Count; i++)
			{
				if (myList[i].Value == max)
				{
					flag = true;
					break;
				}
			}

			if (flag)
				Console.WriteLine("?");
			else
				Console.WriteLine(myList[0].Key);

		}
    }
}
