# Trees
create a binary search and binary search tree with traversal. 

## Challenge

1. Create a BinaryTree class
Define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which returns an array of the values, ordered appropriately.

2. Create a BinarySearchTree class
Define a method named add that accepts a value, and adds a new node with that value in the correct location in the binary search tree.
Define a method named contains that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.

## Approach & Efficiency
First I created a node class, then Binary Search which had inorder, preorder and post order traversal. 
I than create a binary search tree class that inherited the properties of binary search. 
1. Time Complexity BigO for Binary tree traversal is O(n).
2. Time Complexity BigO for Binary tree traversal is O(log n).
3. Space Complexity BigO for Binary tree traversal is O(h). The height of the tree. 

## API
** Methods inside Binary Tree **
PreOrder Traversal: Get the value of the root node first then traverse left and to the right node. 
InOrder Traversal: Get the value of the left node then the root and then the right node. 
PostOrder Traversal: Get the value of the left node, then the right node and then the root node. 

** Methods inside Binary Search Tree **
ADD: Pass a value and then add a node with that value in the tree.
Contains: Check if the tree contains the given value. 

## Visual

![Program test](/Assets/tree.jpg)
