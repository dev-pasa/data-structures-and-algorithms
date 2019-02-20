# Intersection of binary trees
Find common nodes in two binary tree and output a list

## Challenge
Write a function called tree_intersection that takes two binary tree parameters.
Without utilizing any of the built-in library methods available to your language, return a set of values found in both trees.

## Approach & Efficiency
1. Create a list
2. Create a hash table
3. Do a preorder-traversal and push the values to list for first tree
4. Push the values of list to a hashmap
5. Clear the list
6. Do a preorder-traversal and push the values to list for second tree
7. Check for common values and push them to a new list
8. Our output should be common list

## Solution
![TreesCommon](/Assets/TreeComparison.jpg)
![TreesCommon](/Assets/TreeComparison2.jpg)

### Efficiency
* Space Complexity
O(n) 

* Time Complexity
O(n) O(l)
