using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK_game_2023
{


    public class Graph
    {
        List<GraphNode> _nodes;
        List<GraphEdge> _edges;
        public Graph()
        {
            _nodes = new List<GraphNode>();
            _edges = new List<GraphEdge>();
        }
        public void addNode(GraphNode node)
        {
            _nodes.Add(node);
        }




        //public void CreateRandomEdges()
        //{
        //    _edges.Clear();
        //    foreach (var item in _nodes)
        //    {
        //        item.Edges.Clear();
        //    }
        //    foreach (GraphNode node in _nodes)
        //    {
               
        //            int numConnections = Scripts.HelperMethods.RandomSeeder.rnd.Next(0, 4);
        //            for (int i = 0; i < numConnections; i++)
        //            {
        //                Find a random node to connect to
        //                int r = Scripts.HelperMethods.RandomSeeder.rnd.Next(0, _nodes.Count);
        //                if (node != _nodes[r] && node.Edges.Count < 4 && _nodes[r].Edges.Count < 4)
        //                {
        //                    float newWeight = Scripts.HelperMethods.NextFloat(Scripts.HelperMethods.RandomSeeder.rnd, 800, 1500); //cost of passage.
        //                    if (!_edges.Contains(new GraphEdge(node, _nodes[r], newWeight)))
        //                    {
        //                        addEdge(node, _nodes[r], newWeight);
        //                    }
        //                    else i--;

        //                }
        //                else i--;



        //            }
                
              
        //    }
        //}

        public void addEdge(GraphNode nodeA, GraphNode nodeB, float weight)
        {
            GraphEdge edge = new GraphEdge(nodeA, nodeB, weight);
            nodeA.AddEdge(edge);
            nodeB.AddEdge(edge);
            _edges.Add(edge);
        }

        public override string ToString()
        {
            string v = "V = {";
            foreach (GraphNode node in _nodes)
            {
                v += "(" + node.Identification.ToString() + "),";
            }
            v += "}";

            string e = "E = {";

            foreach (GraphEdge edge in _edges)
            {
                e += "(" + edge._name + "),";
            }

            e += "}";



            return v + "\n" + e;
        }

        public string ToMatrix()
        {
            string matrix = "\t";
            foreach (GraphNode nodeA in _nodes)
            {
                matrix += nodeA.ToString() + "\t";
            }
            matrix += "\n";
            foreach (GraphNode nodeA in _nodes)
            {
                matrix += nodeA.ToString() + "\t";
                foreach (GraphNode nodeB in _nodes)
                {
                    float weight = nodeA.GetAdjacentWeight(nodeB);
                    matrix += weight + "\t";
                }
                matrix += "\n";
            }
            return matrix;
        }



    }





    public class GraphEdge
    {
        #region vars
        private GraphNode A;
        private GraphNode B;

        public string _name
        {
            get
            {
                return "Edge " + A.Identification + " - " + B.Identification;
            }
        }

        public GraphNode _A
        {
            get
            {
                return A;
            }
            set
            {
                A = value;
            }
        }
        public GraphNode _B
        {
            get
            { 
                return B;
            }
            set
            {
                B = value;
            }
        }

        private float _weight;

        public float Weight
        {
            get
            {
                return _weight;
            }
        }

#endregion

        public GraphEdge(GraphNode nodeA, GraphNode nodeB, float weight)
        {
            this._A = nodeA;
            this._B = nodeB;
            this._weight = weight;
            nodeA.AddEdge(this);
            if (nodeA != nodeB)
            {
                nodeB.AddEdge(this);
            }
        }


        public bool isIncidentTo(GraphNode node)
        {
            return (_A == node || _B == node);
        }

        public GraphNode getOther(GraphNode current)
        {
            if (current == _A)
            {
                return _B;
            }
            else if (current == _B)
            {
                return _A;
            }
            else
            {
                throw new Exception("NullError@GraphNode.getOther - the supplied node is not connected by this edge.");
            }
        }
        public override string ToString()
        {
            return _A.ToString() + ", " + _B.ToString();
        }

        public string ToString2()
        {
            return _A.ToString() + ", " + _B.ToString() + ", " + Weight;
        }


   
       
    }


    public class GraphNode
    {
        #region  vars

        private List<GraphEdge> _edges;
        public List<GraphEdge> Edges
        {
            get
            {
                return _edges;
            }
        }
        private int _id;

        private TreeNode _shaft;


        public void ChangeShaft(TreeNode shafty)
        {
            _shaft = shafty;
        }

        public TreeNode Shaft
        {
            get
            {
                if (_shaft == null)
                {
                    _shaft = new TreeNode();
                    _shaft.Generate(Wallet.GetRandomCurrency(), Wallet.GetRandomCurrency(), 0, Presets.treeMaxDepth, Presets.standardLuck, 5f, 4f); 
                    // The sequence of random numbers generated by a single Random instance is supposed to be uniformly distributed. Should be fine.
                }
                return _shaft;
            }
        }

        public int Identification
        {
            get => _id;
        }

        #endregion


        public GraphNode()
        {
            
            _id = Presets.lastGraphNodeId;
            Presets.lastGraphNodeId++;
            _edges = new List<GraphEdge>(); //adjacency list
        }



       


        public string GetGraphMatrix()
        {

            string a = "";
            return a;
        }

        int GetDegrees()
        {
            return _edges.Count;
        }

        public void AddEdge(GraphEdge edge)
        {


            _edges.Add(edge);
        }

        public bool IsAdjacent(GraphNode otherNode)
        {
            foreach (GraphEdge edge in _edges)
            {
                if (edge.isIncidentTo(otherNode))
                {
                    return true;
                }
            }
            return false;
        }

        public float GetAdjacentWeight(GraphNode otherNode)
        {
            foreach (GraphEdge edge in _edges)
            {
                if (otherNode == this)
                {
                    if (edge._A == edge._B)
                    {
                        return edge.Weight;
                    }
                }
                else if (edge.isIncidentTo(otherNode))
                {
                    return edge.Weight;
                }
            }
            return 0f;
        }
      

        public GraphNode[] getNeighbours()
        {
            GraphNode[] neighbours = new GraphNode[_edges.Count];
            int i = 0;
            foreach (GraphEdge edge in _edges)
            {
                if (edge._A == this)
                {
                    neighbours[i] = edge._A;
                }
                else
                {
                    neighbours[i] = edge._B;
                }
                i++;
            }
            return neighbours;
        }


    }



}
