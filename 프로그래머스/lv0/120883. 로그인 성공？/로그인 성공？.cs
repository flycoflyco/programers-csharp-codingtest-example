using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
            string answer = "";

            string id = id_pw[0];
            string pw = id_pw[1];

            bool notFound = true;

            for (int i = 0; i < db.GetLength(0); i++)
            {
                string indexId = db[i, 0];
                if (indexId.Equals(id))
                {
                    string indexpw = db[i, 1];
                    if (indexpw.Equals(pw))
                    {
                        answer = "login";
                        break;
                    }
                    else
                    {
                        answer = "wrong pw";
                        break;
                    }
                    notFound = false;
                }
            }

            if (answer==string.Empty && notFound)
			{
                answer = "fail";
			}

            return answer;
    }
}