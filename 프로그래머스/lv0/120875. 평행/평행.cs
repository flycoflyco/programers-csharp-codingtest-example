using System;

public class Solution {
		public int solution(int[,] dots)
		{
			int answer = 0;
			
			int[] p1 = new int[] { dots[0, 0], dots[0, 1] };
			int[] p2 = new int[] { dots[1, 0], dots[1, 1] };
			int[] p3 = new int[] { dots[2, 0], dots[2, 1] };
			int[] p4 = new int[] { dots[3, 0], dots[3, 1] };

			if (IsChecked(p1, p2, p3, p4))
				return 1;
			else if (IsChecked(p1, p3, p2, p4))
				return 1;
			else if (IsChecked(p1, p4, p2, p3))
				return 1;

			return answer;
		}
		public bool IsChecked(int [] p1, int[] p2, int[] p3, int[] p4)
		{
			bool check = IsParallel(p1[0], p2[0], p3[0], p4[0], p1[1], p2[1], p3[1], p4[1]);

			if (check || (p1 == p3 && p2 == p4))
				return true;
			else
				return false;
			
		}
		public bool IsParallel(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4)
		{
			bool result = false;
			double slope1 = (double)(y2 - y1) / (double)(x2 - x1);
			double slope2 = (double)(y4 - y3) / (double)(x4 - x3);
			if (Math.Abs(slope1 - slope2) < 0.000001)
				result = true;
			return result;
		}
}