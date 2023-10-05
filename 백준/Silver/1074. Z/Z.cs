using System;
namespace ConsoleApp1
{
    public class Program
    {

        private static int currRow;
        private static int currCol;

        public static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            string[] cmdSplit = cmd.Split(' ');
            int n = int.Parse(cmdSplit[0]);
            int r = int.Parse(cmdSplit[1]);
            int c = int.Parse(cmdSplit[2]);

            int sideLength = 1;


            for (int i = 0; i < n; i++)
            {
                sideLength *= 2;
            }

            currRow = r;
            currCol = c;
            

            int result = Recursion(0, 0, sideLength-1, sideLength-1);

            result--;

            Console.WriteLine(result);
        }

        public static int Recursion (int startRow, int startCol, int endRow, int endCol)
        {
            int result = 0;
            // ex) 15 -> 8;
            // ex) 7 -> 4;
            int divNum = ((endRow + 1) - startRow) / 2;
            
            if ( divNum == 1)
            {
                if ( currRow == startRow && currCol == startCol)
                    return 1;
                else if (currRow == startRow && currCol == endCol)
                    return 2;
                else if (currRow == endRow && currCol == startCol)
                    return 3;
                else
                    return 4;
            }
            else
            {
                if (currRow < startRow + divNum && currCol < startCol + divNum)
                {
                    result += Recursion(startRow, startCol, startRow + divNum-1, startCol + divNum-1);
                }
                else if (currRow < startRow + divNum && currCol >= startCol + divNum)
                {
                    result += (divNum * divNum);
                    result += Recursion(startRow, startCol + divNum, (startRow + divNum - 1), endCol);
                }
                else if (currRow >= startRow + divNum && currCol < startCol + divNum)
                {
                    result += (divNum * divNum) + (divNum * divNum);
                    result += Recursion(startRow + divNum, startCol, endRow, (startCol + divNum - 1));
                }
                else
                {
                    result += (divNum * divNum) + (divNum * divNum) + (divNum * divNum);
                    result += Recursion(startRow + divNum, startCol + divNum, endRow, endCol);
                }
            }

            return result;
        }
    }
}