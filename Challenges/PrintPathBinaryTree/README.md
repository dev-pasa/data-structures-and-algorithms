# Paths of the tree


## Challenge
- Create a method that takes in a binary tree root node and prints out all the paths in the tree from root to the all leaves.

## Approach & Efficiency

- Create a helper method that takes in length, array for paths and the actual tree root
- if root is null do nothing
- create an array with max size 1000
- as the number of root value inreases, the value in the path increases 
- as the number of nodes increases, the values in the array increases along with it
- if there are no more nodes in the left or right and is the bottom of the tree print the values
- recursive to the left side of the tree and the right side of the tree
- print all the values in the path

- Time Complexity = O(n): Must traverse the whole tree
- Space Compexity = O(h): Where h is the height of the tree

## Solution
![paths tree](/Assets/TreePaths.jpg)

