
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public class GraphNode
        {
            private List<GraphNode> _neighbors;
            public int Data { get; set; }

            public GraphNode()
            {
                IsChecked = false;
            }

            public GraphNode(int value) : base()
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
                foreach (GraphNode index in _nodeList)
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

            public void CheckAllClear()
            {
                foreach (GraphNode index in _nodeList)
                    index.IsChecked = false;
            }


            public int GetDFSResult()
            {
                int result = 0;
                foreach (GraphNode indexNode in this._nodeList)
                {
                    if (!indexNode.IsChecked)
                    {
                        result++;
                        DFS(indexNode);
                    }
                }
                return result;
            }


            private void DFS(GraphNode node)
            {
                if (node.IsChecked)
                    return;
                int result = node.Data;
                _sb.Append(result.ToString() + " ");
                node.IsChecked = true;
                node.Neighbors.Sort((x1, x2) => x1.Data.CompareTo(x2.Data));

                foreach (GraphNode index in node.Neighbors)
                {
                    DFS(index);
                }
            }


        }

        public static void Main(string[] args)
        {
            string cmdStr = Console.ReadLine();
            string[] cmdStrSplit = cmdStr.Split(' ');
            int nodeNum = int.Parse(cmdStrSplit[0]);
            int edgeNum = int.Parse(cmdStrSplit[1]);
            Graph g = new Graph();

            for (int i = 1; i <= nodeNum; i++)
            {
                GraphNode gn = new GraphNode(i);
                g.AddNode(gn);
            }

            for (int i = 0; i < edgeNum; i++)
            {
                string nodeStr = Console.ReadLine();
                string[] nodesSplit = nodeStr.Split(' ');
                int node1 = int.Parse(nodesSplit[0]);
                int node2 = int.Parse(nodesSplit[1]);
                GraphNode gn1 = null;
                GraphNode gn2 = null;

                if (!g.Contains(node1))
                    gn1 = g.AddNode(node1);
                else
                    gn1 = g.Find(node1);

                if (gn1 == null)
                    continue;


                if (!g.Contains(node2))
                    gn2 = g.AddNode(node2);
                else
                    gn2 = g.Find(node2);


                if (gn2 == null)
                    continue;

                g.AddEdge(gn1, gn2, false);
            }
            int result = g.GetDFSResult();

            Console.WriteLine(result);
        }
    }
}