using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    class Graph
    {

        public List<Vertex> Vertices { get; set; }


        public Graph(List<object> values)
        {
            Vertices = new List<Vertex>();
            foreach (object value in values)
            {
                Vertices.Add(new Vertex(value));
            }
        }

        public int Size()
        {
            return Vertices.Count;
        }

    }
}
