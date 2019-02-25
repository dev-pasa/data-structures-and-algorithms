using System;
using System.Collections.Generic;
using System.Text;

namespace graph.Classes
{
    public class Vertex
    {
        public object Value { get; set; }

        /// <summary>
        /// Check if the edgs have been visited
        /// </summary>
        public bool IsVisited { get; set; }

        /// <summary>
        /// Dictionary that is actually holding the verticies
        /// </summary>
        public Dictionary<Vertex, int> AdjacentVertices { get; set; }
        public Vertex(object value)
        {
            Value = value;
            IsVisited = false;
            AdjacentVertices = new Dictionary<Vertex, int>();
        }


    }
}


