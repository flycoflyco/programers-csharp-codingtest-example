using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		// 인풋
		string[] input = Console.ReadLine().Split();
		int n = int.Parse(input[0]);
		int m = int.Parse(input[1]);

		int[,] map = new int[m, n];

		// 주변 토마토체크하는 큐
		Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();

		// 하루 하루 구분하기 위한 리스트
		List<Tuple<int, int>> tomato = new List<Tuple<int, int>>();

		// 모든 토마토가 익었는지 체크하기 위함
		bool noZero = true;

		// 배열에 인풋 저장
		for (int i = 0; i < m; i++)
		{
			string[] row = Console.ReadLine().Split();
			for (int j = 0; j < n; j++)
			{
				map[i, j] = int.Parse(row[j]);
				if (map[i, j] == 1)
				{
					Tuple<int, int> item = new Tuple<int, int>(i, j);
					queue.Enqueue(item);
					tomato.Add(item);
				}
				else if (map[i, j] == 0)
				{
					noZero = false;
				}
			}
		}

		// 모든토마토가 익었으면 0 출력
		if (noZero)
		{
			Console.WriteLine(0);
			return;
		}

		// 상하좌우
		int[] dRow = { -1, 1, 0, 0 };
		int[] dCol = { 0, 0, -1, 1 };

		int cnt = -1;


		while (tomato.Count > 0)
		{
			// 하루치 토마토만 넣는 리스트
			tomato = new List<Tuple<int, int>>();

			// 하루치 토마토 큐 진행
			while (queue.Count > 0)
			{
				// 큐에서 뽑은 토마토의 상하좌우를 체크 후 1 을 넣어주고 다음날 진행시킬 토마토를 리스트에 넣어줌
				var current = queue.Dequeue();
				int x = current.Item1;
				int y = current.Item2;

				for (int k = 0; k < 4; k++)
				{
					int nRow = x + dRow[k];
					int nCol = y + dCol[k];

					if (nRow >= 0 && nRow < m && nCol >= 0 && nCol < n && map[nRow, nCol] == 0)
					{
						map[nRow, nCol] = 1;
						tomato.Add(Tuple.Create(nRow, nCol));
					}
				}
			}

			// 하루치 토마토 큐 while 문이 끝나면 다음날 큐에 토마토들을 넣어줌
			for ( int i = 0; i < tomato.Count; i++)
			{
				queue.Enqueue(tomato[i]);
			}
			// 하루가 지났으니 카운트 증가
			cnt++;
		}

		// 마지막으로 체크해서 토마토가 안익은 곳이 있는지 체크
		for (int i = 0; i < map.GetLength(0); i++)
		{
			bool flag = false;
			for (int j = 0; j < map.GetLength(1); j++)
			{
				if (map[i, j] == 0 )
				{
					cnt = -1;
					flag = true;
					break;
				}

			}
			if (flag)
				break;

		}

		// 출력
		Console.WriteLine(cnt);
	}
}