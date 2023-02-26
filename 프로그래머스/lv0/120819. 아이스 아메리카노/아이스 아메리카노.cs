using System;

public class Solution {
    public int[] solution(int money) 
    {
			int[] answer = new int[2];

			int coffeePrice = 5500;
			int coffeeNum = money / coffeePrice;
			int change = money % coffeePrice;
			answer[0] = coffeeNum;
			answer[1] = change;

			return answer;
    }
}