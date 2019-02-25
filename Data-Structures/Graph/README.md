# Graph
- A graph is a data structure that has two types of elements, vertices and edges.
- The nodes are sometimes also referred to as vertices and the edges are lines or arcs that connect any two nodes in the graph. 
- Graphs are used to solve many real-life problems. 
- Graphs are used to represent networks. The networks may include paths in a city or telephone network or circuit network. 

## Challenge

### Vertex Class

1. AddVertex() 
* Adds a new node to the graph
* Takes in the value of that node
* Returns the added node

* Time complexity O(1), Space Complexity: O(1)


2. AddEdge() 
* Adds a new edge between two nodes in the graph
* Include the ability to have a “weight”
* Takes in the two nodes to be connected by the edge
* Both nodes should already be in the Graph

* Time complexity is O(1) on average, O(n) worst case.


3. GetNodes() 
* Returns all of the nodes in the graph as a collection (set, list, or similar)

* Time complexity is O(1), Space Complexity: O(1) 


4. GetNeighbors() 
* Returns a collection of nodes connected to the given node
* Takes in a given node

* Time Complexity: O(1), Space Complexity: O(1)


5. Size() 
* Returns the total number of nodes in the graph


## Approach & Efficiency
* object Value 
* Constructor Method

* Input - object value
* Creates a new Vertex with Value = value

- Graph 
* Creates a graph with unconnected nodes. DOES NOT HANDLE DUPLICATE NODE VALUES.

Constructor Method

Creates the Adjaceny List

1. AddVertex Method
* Input Vertices vertex
* Creates a new Linked List that holds Edges
* Increases Size of graph by 1


2. AddEdge Method
* Input - Vertex V1, Vertex V2
* Creates a new Linked List 
* Add the Edge to the head of linked list.  

3. GetVerticies Method
* List of Vertices in the Graph

4. GetNeighbors Method
* Return Neighbors linked list

5. GetSize Method
* Return Size of the Graph


## Solution
![Program test](/Assets/)

Reference:

https://www2.cs.duke.edu/courses/cps100e/fall10/class/11_Bacon/code/Graph.html
