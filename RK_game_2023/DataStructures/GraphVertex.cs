using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK_game_2023
{

    public class GraphEdge
    {
        #region vars
        private GraphNode A;
        private GraphNode B;

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
        private string name;

        public string Name
        {
            get => name;
        }

        #endregion


        public GraphNode(int name)
        {
            name = name;
            _edges = new List<GraphEdge>();
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

        void addEdge(GraphEdge edge)
        {
            _edges.Add(edge);
        }



    }



}
