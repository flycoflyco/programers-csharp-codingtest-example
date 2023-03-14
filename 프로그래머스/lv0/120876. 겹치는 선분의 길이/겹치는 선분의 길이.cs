using System;
using System.Collections.Generic;

public class Solution {
		public int solution(int[,] lines)
		{
			int answer = 0;

			int[] line1 = new int[2] { lines[0, 0], lines[0, 1] };
			int[] line2 = new int[2] { lines[1, 0], lines[1, 1] };
			int[] line3 = new int[2] { lines[2, 0], lines[2, 1] };
			// true == start;
			// false == end;
			List<Tuple<bool, int>> data = new List<Tuple<bool, int>>();
			if (IsContains(line1[0], line2, line3))
			{
				Tuple<bool, int> item = new Tuple<bool, int>(true, line1[0]);
				data.Add(item);
			}
			if (IsContains(line1[1], line2, line3))
			{
				Tuple<bool, int> item = new Tuple<bool, int>(false, line1[1]);
				data.Add(item);
			}

			if (IsContains(line2[0], line1, line3))
			{
				Tuple<bool, int> item = new Tuple<bool, int>(true, line2[0]);
				data.Add(item);
			}
			if (IsContains(line2[1], line1, line3))
			{
				Tuple<bool, int> item = new Tuple<bool, int>(false, line2[1]);
				data.Add(item);
			}

			if (IsContains(line3[0], line1, line2))
			{
				Tuple<bool, int> item = new Tuple<bool, int>(true, line3[0]);
				data.Add(item);
			}
			if (IsContains(line3[1], line1, line2))
			{
				Tuple<bool, int> item = new Tuple<bool, int>(false, line3[1]);
				data.Add(item);
			}

			// 겹치는 구간이 없는 경우
			if (data.Count == 0)
				return 0;

			for (int i = 0; i < data.Count-1; i++)
			{
				for ( int j = 0; j < data.Count-1-i; j++)
				{
					if ( data[j].Item2 > data[j+1].Item2)
					{
						Tuple<bool, int> temp = data[j];
						data[j] = data[j + 1];
						data[j + 1] = temp;
					}
					else if ((data[j].Item2 == data[j + 1].Item2) && (!data[j].Item1 && data[j+1].Item1))
					{
						Tuple<bool, int> temp = data[j];
						data[j] = data[j + 1];
						data[j + 1] = temp;
					}
				}
			}


			for (int i = 0; i < data.Count; i++)
			{
				Tuple<bool, int> t1 = data[i];
				for (int j = i+1; j < data.Count; j++)
				{
					Tuple<bool, int> t2 = data[j];
					if (t1.Item1 == t2.Item1 && t1.Item2 == t2.Item2)
					{
						data.RemoveAt(j);
					}

				}
				
			}



			// 제일 처음 구간이 end == false 인 경우, 뭔가 잘못들어온 경우
			if (!data[0].Item1)
				return 0;


			if (data.Count == 2)
			{
				return data[1].Item2 - data[0].Item2;
			}
			else 
			{
				// start, start
				if (data[0].Item1 && data[1].Item1)
				{
					answer = data[data.Count-1].Item2 - data[0].Item2;
					return answer;
				}
				else
				{
					// answer = (data[1].Item2 - data[0].Item2) + (data[3].Item2 - data[2].Item2);
					for (int i = 0; i < data.Count; i = i+2)
					{
						answer += data[i + 1].Item2 - data[i].Item2;
					}
					return answer;
				}
			}
		}

		public bool IsContains(int num, int[] arr1, int[] arr2)
		{
			bool result = false;

			if ( arr1[0] <= num && num <= arr1[1] )
			{
				result = true;
			}

			if (arr2[0] <= num && num <= arr2[1])
			{
				result = true;
			}

			return result;
		}
}