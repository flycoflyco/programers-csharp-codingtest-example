using System;

public class Solution {
    public int solution(int n, int k) {
			int answer = 0;
			int serviceDrink = 0;

			int calculateDrinkNum = 0;
			if ( n > 9)
			{
				serviceDrink = n / 10;
			}

			if ( k >= serviceDrink)
			{
				calculateDrinkNum = k - serviceDrink;
			}
			else
			{
				calculateDrinkNum = 0;
			}

			answer = (n * 12000) + (calculateDrinkNum * 2000);


			return answer;
    }
}