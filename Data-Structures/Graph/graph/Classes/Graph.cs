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
            Vertices.Add(new Vertex(value));
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

    }
}
