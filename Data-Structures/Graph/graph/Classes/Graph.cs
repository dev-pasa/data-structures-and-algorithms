using System;
using System.Collections.Generic;
using System.Text;

namespace graph.Classes
{
    public class Graph
    {
        /// <summary>
        /// Create a list of Vertices
        /// </summary>
        public List<Vertex> Vertices { get; set; }

        /// <summary>
        /// Graph construcotr
        /// </summary>
        /// <param name="values"></param>
        public  Graph(List<object> values)
        {
            Vertices = new List<Vertex>();
            foreach (object value in values)
            {
                Vertices.Add(new Vertex(value));
            }
        }

        /// <summary>
        /// Empty Graph constructor
        /// </summary>
        public Graph()
        {
        }

        /// <summary>
        /// Add vertex
        /// </summary>
        /// <param name="value"></param>
        public void AddVertex(object value)
        {
            Vertex v;
            v = Vertices.Find(x => x.Value == value);
            if(v == null)
            {
                Vertices.Add(new Vertex(value));
            }
           
        }

        /// <summary>
        /// Add the edges
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="weight"></param>
        public void AddEdge(object v1, object v2, int weight)
        {
            Vertex vertex1 = Vertices.Find(x => x.Value == (object)v1);
            if (vertex1 == null)
            {
                vertex1 = new Vertex(v1);
                Vertices.Add(vertex1);
            }

            Vertex vertex2 = Vertices.Find(x => x.Value == v2);

            if (vertex2 == null)
            {
                vertex2 = new Vertex(v2);
                Vertices.Add(vertex2);
            }
            //Add key and value pairs
            vertex1.AdjacentVertices.Add(vertex2, weight);
            vertex2.AdjacentVertices.Add(vertex1, weight);
        }

        /// <summary>
        /// Method that outputs the size of the Graph
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return Vertices.Count;
        }

        /// <summary>
        /// Get all the nodes in the vertices
        /// </summary>
        /// <returns></returns>
       public List<Vertex> GetVertexes()
        {
            return Vertices;
        }

        public Dictionary<string, int> GetNeighbors(object value)
        {
            //Find the node in the list of vertices
            Vertex vertexes = Vertices.Find(x => x.Value == value);
            //if node not present return null
            if(vertexes == null)
            {
                return null;
            }
            //return nodes of adjacent vertices
            Dictionary<string, int> neighbors = new Dictionary<string, int>();
            foreach(var val in vertexes.AdjacentVertices)
            {
                var key = val.Key;
                neighbors.Add((string)key.Value, vertexes.AdjacentVertices[key]);
            }
            //return the neighbors
            return neighbors;
        }

        /// <summary>
        /// Beadth First Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<Vertex> BreadthFirst(Vertex root)
        {
            List<Vertex> order = new List<Vertex>();
            Queue<Vertex> breadth = new Queue<Vertex>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Vertex front = breadth.Dequeue();
                order.Add(front);

                foreach (Vertex child in Vertices)
                {
                    if (!child.IsVisited)
                    {
                        child.IsVisited = true;
                        breadth.Enqueue(child);
                    }
                }
            }

            return order;
        }

    }
}
