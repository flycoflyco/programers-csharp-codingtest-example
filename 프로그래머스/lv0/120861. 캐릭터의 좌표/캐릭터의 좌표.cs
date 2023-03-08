using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
			int[] answer = new int[2] { 0, 0};

			int leftEnd = ((board[0] - 1) / 2) * -1;
			int rightEnd = ((board[0] - 1) / 2);
			int upEnd = ((board[1] - 1) / 2);
			int downEnd = ((board[1] - 1) / 2) * -1;

			for (int i = 0; i < keyinput.Length; i++)
			{
				string input = keyinput[i];

				switch(input)
				{
					case "left":
						if (answer[0] > leftEnd)
							answer[0]--;
						break;
					case "right":
						if (answer[0] < rightEnd)
							answer[0]++;
						break;
					case "up":
						if (answer[1] < upEnd)
							answer[1]++;
						break;
					case "down":
						if (answer[1] > downEnd)
							answer[1]--;
						break;
				}
			}

			return answer;
    }
}