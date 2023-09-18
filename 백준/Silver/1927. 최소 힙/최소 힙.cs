

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Heap
    {
        List<int> arr;
        
        public Heap(int count)
        {
            // index를 1부터 시작하기 위해서 count+1과 -1 을 add 함
            arr = new List<int>(count+1);
            arr.Add(-1);
        }

        public void Add(int inputNum)
        {
            // 노드 추가
            arr.Add(inputNum);
            // 현재 추가된 노드는 맨 마지막에 있으므로 count - 1
            int i = arr.Count - 1;

            //마지막 부터 루트노드까지
            while (i > 1)
            {
                // arr[i] : 현재 삽입한 노드
                // arr[i/2] : 현재 삽입한 노드의 부모노드
                // 현재 삽입한 노드가 부모노드보다 작다면 스왑
                if (arr[i] < arr[i / 2])
                {
                    Swap(i, i / 2);
                    i = i / 2;
                }
                else
                {
                    break;
                }
            }
            
        }

        public int RemoveRoot()
        {
            if (arr.Count == 1)
                return 0;
            // root 를 결과물에 넣어주고
            int result = arr[1];
            // 제일 마지막에 있는애를 루트로 올린다 
            arr[1] = arr[arr.Count - 1];
            // root 를 리스트에서 삭제한다
            arr.RemoveAt(arr.Count - 1);

            // add 의 경우 마지막 부터 루트노드까지였다면
            // remove 의 경우 root 부터 마지막까지이므로  반대이다
            int i = 1;
            while (i < arr.Count - 1)
            {
                if (i * 2 <= arr.Count -1 && arr[i] > arr[i*2] )
                {
                    //// 좌측 child 보다 크다면
                    //근데 우측이 까지 트리가 있다면 우측도 비교를 해야함
                    if ((i * 2) + 1 <= arr.Count - 1)
                    {
                        // 우측이 더 작으면 우측으로 넣어준다
                        if (arr[i * 2] > arr[(i * 2) + 1 ])
                        {
                            Swap(i, (i * 2) + 1);
                            i = (i * 2) + 1;
                        }
                        else
                        {
                            Swap(i, i * 2);
                            i = i * 2;
                        }
                    }
                    else
                    {
                        // 좌측 child 보다 크지만 우측이 없으면 좌측이랑 교환
                        Swap(i, i * 2);
                        i = i * 2;
                    }
                }
                else if ((i * 2) + 1 <= arr.Count - 1 && arr[i] > arr[(i * 2) + 1])
                {
                    // 우측 child 보다 크다면
                    Swap(i, (i * 2) + 1);
                    i = (i * 2) + 1;
                }
                else
                {
                    // 양측 다 안크다고 하면 break;
                    break;
                }
            }

            return result;
        }

        public void Swap (int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Heap h = new Heap(n);
            StringBuilder sb = new StringBuilder();

            for ( int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    int root = h.RemoveRoot();
                    sb.AppendLine(root.ToString());
                }
                else
                {
                    h.Add(input);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
