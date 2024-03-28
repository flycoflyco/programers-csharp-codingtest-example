using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
	static void Main()
	{
		// 가로 세로 사이즈 인풋
		string[] input = Console.ReadLine().Split();
		int n = int.Parse(input[0]);
		int m = int.Parse(input[1]);

		// 배열 인풋
		int[,] map = new int[n, m];

		// 도착해야하는 곳 (값이 2인곳)
		Tuple<int, int> destination = null;

		// 배열에 인풋 저장
		for (int i = 0; i < n; i++)
		{
			string[] row = Console.ReadLine().Split();
			for (int j = 0; j < m; j++)
			{
				map[i, j] = int.Parse(row[j]);
				if (map[i, j] == 2)
				{
					destination = Tuple.Create(i, j);
				}
			}
		}

		// 결과물 배열
		int[,] distances = CalculateDistances(map, destination, n, m);

		StringBuilder sb = new StringBuilder();

		// 출력
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < m; j++)
			{
				sb.Append(distances[i, j] + " ");
			}
			sb.AppendLine();
		}
		StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
		sw.WriteLine(sb.ToString());
		sw.Close();
	}

	static int[,] CalculateDistances(int[,] map, Tuple<int, int> destination, int n, int m)
	{
		int[,] distances = new int[n, m];
		Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();

		// 도착할 곳의 좌표
		int destX = destination.Item1;
		int destY = destination.Item2;

		// 초기화
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < m; j++)
			{
				distances[i, j] = map[i, j] == 1 ? -1 : 0;
				if (map[i, j] == 2)
				{
					// 도착할 곳을 큐에 넣어줌
					queue.Enqueue(Tuple.Create(i, j));
					// 도착할 곳은 거리가 0이므로
					distances[i, j] = 0;
				}
			}
		}

		// 상하좌우 
		int[] dx = { 0, 0, 1, -1 };
		int[] dy = { 1, -1, 0, 0 };

		// BFS
		while (queue.Count > 0)
		{
			var current = queue.Dequeue();
			int x = current.Item1;
			int y = current.Item2;

			for (int k = 0; k < 4; k++)
			{
				int nx = x + dx[k];
				int ny = y + dy[k];

				if (nx >= 0 && nx < n && ny >= 0 && ny < m && distances[nx, ny] == -1)
				{
					distances[nx, ny] = distances[x, y] + 1;
					queue.Enqueue(Tuple.Create(nx, ny));
				}
			}
		}

		return distances;
	}
}