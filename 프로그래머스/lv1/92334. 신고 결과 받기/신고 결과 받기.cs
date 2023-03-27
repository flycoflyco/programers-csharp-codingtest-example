using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
			int[] answer = new int[] { };

			Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
			Dictionary<string, List<string>> reportNums = new Dictionary<string, List<string>>();

			for ( int i = 0; i < id_list.Length; i++)
			{
				dic.Add(id_list[i], new List<string>());
				reportNums.Add(id_list[i], new List<string>());
			}

			for ( int i = 0; i < report.Length; i++)
			{
				string[] pair = report[i].Split(' ');
				string keyUser = pair[0];
				string reportUser = pair[1];
				if (dic.ContainsKey(keyUser))
				{
					if (!dic[keyUser].Contains(reportUser))
						dic[keyUser].Add(reportUser);
				}
				if (reportNums.ContainsKey(reportUser))
				{
					if (!reportNums[reportUser].Contains(keyUser))
						reportNums[reportUser].Add(keyUser);

				}
			}

			List<string> reportList = new List<string>();

			foreach (string key in reportNums.Keys)
			{
				if (reportNums[key].Count >= k)
				{
					reportList.Add(key);
				}
			}

			answer = new int[dic.Keys.Count];


			int answerIndex = 0;
			foreach (string key in dic.Keys)
			{
				List<string> todo = dic[key];
				for (int l = 0; l < todo.Count; l++)
				{
					string index1 = todo[l];
					for (int j = 0; j < reportList.Count; j++)
					{
						string index2 = reportList[j];
						if (index1 == index2)
						{
							answer[answerIndex]++;
						}
					}
				}
				answerIndex++;
			}


			return answer;
    }
}