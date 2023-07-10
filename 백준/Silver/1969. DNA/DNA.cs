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


			#region 인풋
			// n, m
			string nmStr = Console.ReadLine();
			string[] nmStrSplit = nmStr.Split(' ');
			int n = Convert.ToInt32(nmStrSplit[0]);
			int m = Convert.ToInt32(nmStrSplit[1]);

			// dna
			string[] dnas = new string[n];
			for (int i = 0; i < n; i++)
				dnas[i] = Console.ReadLine();
			#endregion

			char[,] dnaCh = new char[n, m];

			for ( int i = 0; i < n;i++)
			{
				string indexStr = dnas[i];
				for ( int j = 0; j < m; j++)
				{
					char ch = indexStr[j];
					dnaCh[i, j] = ch;
				}
			}

			char[] result1 = new char[m];
			for ( int i = 0; i < m; i++)
			{
				char[] index = new char[n];
				for ( int j = 0; j < n; j++)
				{
					index[j] = dnaCh[j, i];
				}
				result1[i] = GetMostDNASortAlpha(index);
			}

			int result2 = 0;

			for ( int i = 0; i < n; i++)
			{
				for ( int j = 0;  j < m; j++)
				{
					if (result1[j] != dnaCh[i, j])
					{
						result2++;
					}
				}
			}

			Console.WriteLine(new string(result1));
			Console.WriteLine(result2);

		}

		private static char GetMostDNASortAlpha (char[] chs)
		{
			char[] ncl = { 'A', 'C', 'G', 'T' };
			int[] nclCnt = new int[ncl.Length];
			char result = ncl[0];

			for ( int i = 0; i < chs.Length; i++)
			{
				char indexCh = chs[i];
				for ( int j = 0; j < ncl.Length; j++)
				{
					if ( indexCh == ncl[j])
					{
						nclCnt[j]++;
					}
				}
			}

			int max = int.MinValue;
			int maxIndex = -1;
			for ( int i = 0; i <  nclCnt.Length; i++)
			{
				int cnt = nclCnt[i];
				if (cnt > max)
				{
					max = cnt;
					maxIndex = i;
				}
			}

			result = ncl[maxIndex];
			return result;
		}




	}
}
