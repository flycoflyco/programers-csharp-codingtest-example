using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string caseStr = Console.ReadLine();
            caseStr = caseStr.Replace("+", "^+^");
            caseStr = caseStr.Replace("-", "^-^");
            string[] caseStrSplit = caseStr.Split('^');
            List<int> operands = new List<int>();
            List<string> operators = new List<string>();
            for (int i = 0; i < caseStrSplit.Length; i++)
            {
                string str = caseStrSplit[i];
                int num = 0;
                if (int.TryParse(str.ToString(), out num))
                    operands.Add(num);
                else if (str == "+" || str == "-")
                    operators.Add(str);
            }
            int result = operands[0];
            int operatorCnt = 0;
            int operandCnt = 1;
            while (operandCnt < operands.Count && operatorCnt < operators.Count)
            {
                int opNum = operands[operandCnt];
                string op = operators[operatorCnt];

                if (op == "+")
                {
                    result += opNum;
                    operatorCnt++;
                    operandCnt++;
                }
                else
                {
                    int tempSum = 0;
                    do
                    {
                        opNum = operands[operandCnt];
                        tempSum += opNum;
                        operatorCnt++;
                        operandCnt++;
                    }
                    while (operatorCnt < operators.Count && operators[operatorCnt] != "-");
                    result -= tempSum;
                }
            }
            Console.WriteLine(result);
        }
    }
}