using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] answers)
    {
			int[] answer = new int[3] { 0, 0, 0 };
			int[] ASupo = new int[] { 1, 2, 3, 4, 5 }; // 5 
			int[] BSupo = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 }; // 8
			int[] CSupo = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 }; // 10

			int aNum = 0;
			int bNum = 0;
			int cNum = 0;
			for (int i = 0; i < answers.Length; i++)
			{
				if (answers[i] == ASupo[i % 5])
				{
					aNum++;
				}
				if (answers[i] == BSupo[i % 8])
				{
					bNum++;
				}
				if (answers[i] == CSupo[i % 10])
				{
					cNum++;
				}
			}

			if (aNum == bNum && bNum == cNum)
			{
				// 모두 같은거
				answer = new int[3] { 1, 2, 3 };
			}
			else 
			{
				List<Tuple<int, int>> tuples = new List<Tuple<int, int>>();
				Tuple<int, int> item1 = new Tuple<int, int>(1, aNum);
				Tuple<int, int> item2 = new Tuple<int, int>(2, bNum);
				Tuple<int, int> item3 = new Tuple<int, int>(3, cNum);
				tuples.Add(item1);
				tuples.Add(item2);
				tuples.Add(item3);

				// 정렬
				tuples.Sort(delegate (Tuple<int, int> t1, Tuple<int, int> t2)
			   {
				   return t2.Item2.CompareTo(t1.Item2);
			   });

				if (tuples[0].Item2 == tuples[1].Item2)
				{
					answer = new int[2];
					// 1등과 2등이 같다면, 공동1등 나머지 3등으로 오름차순 정렬 후 정답으로 출력
					if ( tuples[0].Item1 > tuples[1].Item1)
					{
						answer[0] = tuples[1].Item1;
						answer[1] = tuples[0].Item1;
					}
					else
					{
						answer[0] = tuples[0].Item1;
						answer[1] = tuples[1].Item1;
					}
				}
				else
				{
					// 다르다면, 단독 1등이므로 1등만 출력
					answer = new int[1];
					answer[0] = tuples[0].Item1;
				}
			}

			return answer;
    }
}