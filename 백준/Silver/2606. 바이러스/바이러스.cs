using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
       
        class Node
        {
            public Node(int value)
            {
                _virusCheck = false;
                _virus = false;
                ComputerNum = value;
                if (ConnectNodes == null)
                    ConnectNodes = new List<Node>();
            }
            public List<Node> ConnectNodes { get; set; }
            public int ComputerNum { get; set; }
            private bool _virus;
            private bool _virusCheck;
            public bool Virus
            {
                get
                {
                    return _virus;
                }
                set
                {
                    _virus = value;
                    if (value && !_virusCheck)
                    {
                        _virusCheck = true;
                        foreach (Node index in ConnectNodes)
                        {
                            index.Virus = true;
                        }
                    }
                }
            }




            
            public void Add(int value)
            {
                ConnectNodes.Add(new Node(value));
            }

            public override bool Equals(object obj)
            {
                if (obj != null && obj is Node n)
                    return n.ComputerNum == ComputerNum;
                else
                    return false;
            }

        }

        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int tupleNum = int.Parse(Console.ReadLine());

            List<Node> nodes = new List<Node>();

            for (int i = 0; i < tupleNum; i++)
            {
                string tupleString = Console.ReadLine();
                string[] tupleStringSplit = tupleString.Split(' ');
                int pc1 = int.Parse(tupleStringSplit[0]);
                int pc2 = int.Parse(tupleStringSplit[1]);

                Node pc1Node = nodes.Find(x => x.ComputerNum == pc1);
                Node pc2Node = nodes.Find(x => x.ComputerNum == pc2);

                if (pc1Node == null)
                {
                    pc1Node = new Node(pc1);
                    nodes.Add(pc1Node);
                }

                if (pc2Node == null)
                {
                    pc2Node = new Node(pc2);
                    nodes.Add(pc2Node);
                }
                    
                if ( !pc1Node.ConnectNodes.Contains(pc2Node))
                {
                    pc1Node.ConnectNodes.Add(pc2Node);
                }

                if (!pc2Node.ConnectNodes.Contains(pc1Node))
                {
                    pc2Node.ConnectNodes.Add(pc1Node);
                }
            }
            int result = 0;
            if (nodes.Count > 0)
            {
                Node firstPc = nodes.Find(x => x.ComputerNum == 1);
                firstPc.Virus = true;
                for (int i = 0; i < nodes.Count; i++)
                {
                    Node node = nodes[i];
                    if (node.ComputerNum != 1 && node.Virus)
                        result++;
                }
            }
            Console.WriteLine(result);
         }
    }
}