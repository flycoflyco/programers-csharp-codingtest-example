using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> ingredientList = new List<int>(ingredient);
        List<int> hamburger = new List<int>();
        int floor = 0;
        bool isFlag = false;

        while (ingredientList.Count != 0 && floor < ingredientList.Count)
        {
            switch (ingredientList[floor])
            {
                case 1:
                    if (hamburger.Count != 0 && hamburger[hamburger.Count - 1] == 3)
                    {
                        answer++;
                        hamburger.RemoveRange(hamburger.Count - 3, 3);
                        ingredientList.RemoveRange(floor - 3, 4);
                        isFlag = true;
                        break;
                    }

                    hamburger.Add(ingredientList[floor]);
                    break;

                case 2:
                    if (hamburger.Count == 0)
                        break;

                    if (hamburger[hamburger.Count - 1] == 1)
                        hamburger.Add(ingredientList[floor]);
                    else
                        hamburger.Clear();
                    break;

                case 3:
                    if (hamburger.Count == 0)
                        break;

                    if (hamburger[hamburger.Count - 1] == 2)
                        hamburger.Add(ingredientList[floor]);
                    else
                        hamburger.Clear();
                    break;
            }

            if (isFlag)
            {
                floor = floor - 3 < 0? 0 : floor - 3;
                isFlag = false;
            }
            else
            {
                floor++; 
            }
        }

        return answer;
    }
}