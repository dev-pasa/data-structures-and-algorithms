using graph.Classes;
using System;
using System.Collections.Generic;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> fruits = new List<object>();
            fruits.Add("Grape");
            Graph graph = new Graph(fruits);


        }

        /// <summary>
        /// Create a GetEdge method to check for bridge between vertices and get their weight
        /// </summary>
        /// <param name="input"></param>
        /// <param name="connections"></param>
        /// <returns></returns>
        public static Dictionary<bool, int> GetEdge(string[] input, Graph connections)
        {
            Dictionary<bool, int> path = new Dictionary<bool, int>();
            Vertex current;

            foreach (var vertex in connections.Vertices)
            {
                if (vertex.Value == input[0])
                {
                    current = vertex;
                }
            }

           for(int i = 0; i < input.Length; i++)
            {
                Dictionary<string, int> Neighbors = connections.GetNeighbors(current);
                foreach(current.AdjacentVertices in Neighbors.Values)
                {
                    if(current.AdjacentVertices.Values == input[1])
                    {
                        path.Add<true, >
                    }
                }
            }
        }
    }
}
