using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers_CSharp_Codingtest_Example.ExampleSourceCode
{
	public class Parallel
	{
		// 평행 문제
		// 점 네 개의 좌표를 담은 이차원 배열 dots가 다음과 같이 매개변수로 주어집니다.
		// [[x1, y1], [x2, y2], [x3, y3], [x4, y4]]
		// 주어진 네 개의 점을 두 개씩 이었을 때, 두 직선이 평행이 되는 경우가 있으면 1을 없으면 0을 return 하도록 solution 함수를 완성해보세요.


		//static void Main(string[] args)
		//{
		//	int[,] dots1 = new int[,] { { 1, 4 }, { 9, 2 }, { 3, 8 }, { 11, 6 } };
		//	int a = solution(dots1);
		//}

		public int solution(int[,] dots)
		{
			int answer = 0;

			// 배열을 Point 형태로 바꿔준다
			int[] p1 = new int[] { dots[0, 0], dots[0, 1] }; 
			int[] p2 = new int[] { dots[1, 0], dots[1, 1] };
			int[] p3 = new int[] { dots[2, 0], dots[2, 1] };
			int[] p4 = new int[] { dots[3, 0], dots[3, 1] };

			// 조합별로 평행인지 체크한다
			if (IsChecked(p1, p2, p3, p4))
				return 1;
			else if (IsChecked(p1, p3, p2, p4))
				return 1;
			else if (IsChecked(p1, p4, p2, p3))
				return 1;

			return answer;
		}
		public bool IsChecked(int[] p1, int[] p2, int[] p3, int[] p4)
		{
			// 평행인지 체크
			bool check = IsParallel(p1[0], p2[0], p3[0], p4[0], p1[1], p2[1], p3[1], p4[1]);

			if (check || (p1 == p3 && p2 == p4))
				return true;
			else
				return false;

		}
		public bool IsParallel(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4)
		{
			bool result = false;
			// 기울기 비교로 평행인지 체크
			// (주의) 기울기 (double) 을 써주지 않으면 int값으로 기울기가 나오면
			// 정확하지 않으니까 조심
			double slope1 = (double)(y2 - y1) / (double)(x2 - x1); 
			double slope2 = (double)(y4 - y3) / (double)(x4 - x3);
			if (Math.Abs(slope1 - slope2) < 0.000001)
				result = true;
			return result;
		}
	}
}
