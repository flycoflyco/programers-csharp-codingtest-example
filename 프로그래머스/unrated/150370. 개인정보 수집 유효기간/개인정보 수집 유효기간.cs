using System;
using System.Collections.Generic;

public class Solution {
		public int[] solution(string today, string[] terms, string[] privacies)
		{
			int[] answer = new int[] { };
			List<int> answer_lst = new List<int>();
			DateTime today_Date = GetDateTime(today);
			Dictionary<string, int> terms_dic = new Dictionary<string, int>();
			for ( int i = 0; i < terms.Length; i++)
			{
				string[] indexTerms = terms[i].Split(' ');
				terms_dic.Add(indexTerms[0], Convert.ToInt32(indexTerms[1]));
			}

			for ( int i = 0; i< privacies.Length; i++)
			{
				string prv = privacies[i];
				string[] prv_split = prv.Split(' ');
				DateTime prvTime = GetDateTime(prv_split[0]);
				int expiration = terms_dic[prv_split[1]];
				prvTime = prvTime.AddMonths(expiration);
				prvTime = prvTime.AddHours(-1);
				if (prvTime < today_Date)
				{
					answer_lst.Add(i + 1);
				}
			}
			answer = answer_lst.ToArray();
			return answer;
		}

		public DateTime GetDateTime(string date)
		{
			DateTime result = new DateTime();
			string[] dateSplit = date.Split('.');
			result = new DateTime(Convert.ToInt32(dateSplit[0]), Convert.ToInt32(dateSplit[1]), Convert.ToInt32(dateSplit[2]));
			return result;
		}
}