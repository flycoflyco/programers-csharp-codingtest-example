using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string nStr = Console.ReadLine();
            int num = Convert.ToInt32(nStr);
            
            string[] answer = new string[num];
            for (int i = 0; i < num; i++)
            {
                string cmdStr = Console.ReadLine();
                string[] cmd = cmdStr.Split(' ');
                int h = Convert.ToInt32(cmd[0]);
                int w = Convert.ToInt32(cmd[1]);
                int n = Convert.ToInt32(cmd[2]);

                int cnt = 0;
                int j, k =1;
                for ( j = 1; j <= w; j++)
                {
                    bool flag = false;
                    for (k = 1; k <= h; k++)
                    {
                        cnt++;

                        if (cnt == n)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                if (j < 10)
                    answer[i] = (k).ToString() + "0" + (j).ToString();
                else
                    answer[i] = (k).ToString() + (j).ToString();
            }
            foreach (string a in answer)
            {
                Console.WriteLine(a);
            }
        }
    }
}