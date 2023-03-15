using System;

public class Solution {
    public int solution(int chicken) {
			int answer = 0;

			if (chicken < 10)
				return answer;

			int serviceCoupon = chicken;
			while (serviceCoupon >= 10)
			{
				answer = answer + serviceCoupon / 10;
				int mok = serviceCoupon / 10;
				int margin = serviceCoupon % 10;
				serviceCoupon = mok + margin;

			}
			return answer;
    }
}