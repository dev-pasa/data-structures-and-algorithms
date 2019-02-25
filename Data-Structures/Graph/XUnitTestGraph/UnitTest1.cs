using System;
using Xunit;
using System.Collections.Generic;
using graph.Classes;


namespace XUnitTestGraph
{
    public class UnitTest1
    {
        /// <summary>
        /// Test the vertex in the graph
        /// </summary>
        /// <param name="fruit1"></param>
        /// <param name="fruit2"></param>
        /// <param name="fruit3"></param>
        [Theory]
        [InlineData("Apple", "Banana", "Orange")]
        public void AddVertex(string fruit1, string fruit2, string fruit3)
        {
            List<object> fruits = new List<object>();

            fruits.Add(fruit1);
            fruits.Add(fruit2);
            fruits.Add(fruit3);
            Graph graph = new Graph(fruits);
            List<Vertex> nodes = graph.GetVertexes();
            Assert.True(fruits[0] == nodes[0].Value && fruits[1] == nodes[1].Value && fruits[2] == nodes[2].Value);
        }

        /// <summary>
        /// Test the Get Nodes in the Graph
        /// </summary>
        /// <param name="fruit1"></param>
        /// <param name="fruit2"></param>
        /// <param name="fruit3"></param>
        [Theory]
        [InlineData("Apple", "Banana", "Orange")]
        [InlineData("Grape", "Berry", "Blue Berry")]
        [InlineData("Guava", "Mango", "Cucumber")]
        public void TestGetNodes(string fruit1, string fruit2, string fruit3)
        {
            List<object> fruits = new List<object>();
            fruits.Add(fruit1);
            fruits.Add(fruit2);
            fruits.Add(fruit3);
            Graph graph = new Graph(fruits);
            List<Vertex> nodes = graph.GetVertexes();

            Assert.True(fruits[0] == nodes[0].Value && fruits[1] == nodes[1].Value && fruits[2] == nodes[2].Value);
        }

        /// <summary>
        /// Test the size of the Graph
        /// </summary>
        [Fact]
        public void TestSize1()
        {
            List<object> fruits = new List<object>();
            Graph graph = new Graph(fruits);
            Assert.Equal(0, graph.Size());
        }

        /// <summary>
        /// Test the size of the Graph
        /// </summary>
        [Fact]
        public void TestSize2()
        {
            List<object> fruits = new List<object>();
            fruits.Add("Grape");
            Graph graph = new Graph(fruits);
            Assert.Equal(1, graph.Size());
        }

        /// <summary>
        /// Test the size of the Graph
        /// </summary>
        [Fact]
        public void TestSize3()
        {
            List<object> fruits = new List<object>();
            fruits.Add("Grape");
            fruits.Add("Orange");
            Graph graph = new Graph(fruits);
            Assert.Equal(2, graph.Size());
        }
    }


}
