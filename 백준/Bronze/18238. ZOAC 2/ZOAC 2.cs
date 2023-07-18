using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string numStr = Console.ReadLine();
            LinkedList<char> alpha = new LinkedList<char>();

            for ( int i = 65; i <= 90; i++)
            {
                char ch = Convert.ToChar(i);
                alpha.AddLast(ch);
            }

            int cntSum = 0;
            
            LinkedListNode<char> current = alpha.First;

            for (int i = 0; i < numStr.Length; i++)
            {
                char ch = numStr[i];
                LinkedListNode<char> prev = current;

                int cntCW = 0;
                while (true)
                {
                    if ( current.Value == ch)
                    {
                        break;
                    }
                    else
                    {
                        current = current.Next ?? current.List.First;
                    }
                    cntCW++;
                }

                current = prev;
                int cntCCW = 0;
                while (true)
                {
                    if (current.Value == ch)
                        break;
                    else
                        current = current.Previous ?? current.List.Last;

                    cntCCW++;
                }

                if (cntCCW > cntCW)
                    cntSum += cntCW;
                else
                    cntSum += cntCCW;
            }
            Console.WriteLine(cntSum);


        }
    }
}
