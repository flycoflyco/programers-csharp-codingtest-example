

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    public class GraphNode
    {
        private List<GraphNode> _neighbors;
        public int Data { get; set; }

        public GraphNode()
        {
            IsChecked = false;
        }

        public GraphNode(int value) : base ()
        {
            this.Data = value;
        }

        public List<GraphNode> Neighbors
        {
            get
            {
                _neighbors = _neighbors ?? new List<GraphNode>();
                return _neighbors;
            }
        }


        public bool IsChecked { get; set; }


    }

    // Graph 클래스
    public class Graph
    {
        private List<GraphNode> _nodeList;
        private StringBuilder _sb;

        public Graph()
        {
            _nodeList = new List<GraphNode>();
            _sb = new StringBuilder();
        }

        public GraphNode AddNode(int data)
        {
            GraphNode n = new GraphNode(data);
            _nodeList.Add(n);
            return n;
        }

        public GraphNode AddNode(GraphNode node)
        {
            _nodeList.Add(node);
            return node;
        }

        public void AddEdge(GraphNode from, GraphNode to, bool oneway = true)
        {
            from.Neighbors.Add(to);
            if (!oneway)
            {
                to.Neighbors.Add(from);
            }
        }
        public bool Contains(int value)
        {
            bool result = false;
            foreach ( GraphNode index in _nodeList)
            {
                if (index == null)
                    continue;

                if (index.Data == value)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public GraphNode Find(int value)
        {
            GraphNode result = null;
            foreach (GraphNode index in _nodeList)
            {
                if (index == null)
                    continue;

                if (index.Data == value)
                {
                    result = index;
                    break;
                }
            }
            return result;
        }

        public void CheckAllClear ()
        {
            foreach (GraphNode index in _nodeList)
                index.IsChecked = false;
        }


        public StringBuilder GetDFSResult(GraphNode startNode)
        {
            _sb = new StringBuilder();
            DFS(startNode);
            return _sb;
        }

        public StringBuilder GetBFSResult(GraphNode startNode)
        {
            _sb = new StringBuilder();
            BFS(startNode);
            return _sb;
        }

        private void BFS(GraphNode startNode)
        {
            Queue<GraphNode> q = new Queue<GraphNode>();
            HashSet<GraphNode> itemCovered = new HashSet<GraphNode>();
            q.Enqueue(startNode);
            while (q.Count > 0)
            {
                GraphNode node = q.Dequeue();
                if (node.IsChecked)
                {
                    continue;
                }
                else
                {
                    itemCovered.Add(node);
                    node.IsChecked = true;
                }
                    

                _sb.Append(node.Data.ToString() + " ");

                node.Neighbors.Sort((x1, x2) => x1.Data.CompareTo(x2.Data));

                foreach (GraphNode childNode in node.Neighbors)
                {
                    if (!childNode.IsChecked)
                    {
                        q.Enqueue(childNode);
                    }
                }
            }
        }


        private void DFS(GraphNode node)
        {
            if (node.IsChecked)
                return;
            int result = node.Data;
            _sb.Append(result.ToString() + " ");
            node.IsChecked = true;
            node.Neighbors.Sort((x1, x2) => x1.Data.CompareTo(x2.Data));

            foreach ( GraphNode index in node.Neighbors)
            {
                DFS(index);
            }
        }


    }
    class Program
    {
        public static void Main(string[] args)
        {
            string nmvStr = Console.ReadLine();
            string[] nmvStrSplit = nmvStr.Split(' ');
            int n = int.Parse(nmvStrSplit[0]);
            int m = int.Parse(nmvStrSplit[1]);
            int v = int.Parse(nmvStrSplit[2]);

            Graph g = new Graph();

            for (int i = 0; i < m; i++)
            {
                string edge = Console.ReadLine();
                string[] edgeSplit = edge.Split(' ');
                int edgeValue1 = int.Parse(edgeSplit[0]);
                int edgeValue2 = int.Parse(edgeSplit[1]);
                GraphNode edge1 = null;
                GraphNode edge2 = null;

                if ( !g.Contains(edgeValue1))
                    edge1 = new GraphNode(edgeValue1);
                else
                    edge1 = g.Find(edgeValue1);

                if (edge1 == null)
                    continue;

                g.AddNode(edge1);

                if (!g.Contains(edgeValue2))
                    edge2 = new GraphNode(edgeValue2);
                else
                    edge2 = g.Find(edgeValue2);

                if (edge2 == null)
                    continue;

                g.AddNode(edge2);

                g.AddEdge(edge1, edge2, false);
            }
            GraphNode startNode = g.Find(v);
            if (startNode == null)
            {
                startNode = new GraphNode(v);
                g.AddNode(startNode);
            }

            StringBuilder sb = g.GetDFSResult(startNode);
            string temp = sb.ToString();
            temp = temp.TrimEnd(' ');
            Console.WriteLine(temp);

            g.CheckAllClear();

            sb = g.GetBFSResult(startNode);
            temp = sb.ToString();
            temp = temp.TrimEnd(' ');
            Console.WriteLine(temp);
        }

    }
}
