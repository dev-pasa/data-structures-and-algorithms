# Binary Tree Has Sum Path


## Challenge
* Check whether the path in a binary tree add up to the sum
* Return a boolean value to indicate whether the sum of path is equal to the given sum. 


## Approach & Efficiency

 - check if the sum of any path add-up to given sum
 - if root is null sum is 0 and return false
 - create a boolean value to return answer
 - create an int variable whose value is sum minus root value
 - if path total is zero and there are no more nodes remain either in left or right return true
 - do recursive check in left side of the tree
 - do recursive check in right side of tree
 - return the boolean ans
 
* Time Complexity = O(n): Must traverse the whole tree
* Space Compexity = O(1): Where h is the height of the tree

## Solution
![Binary Tree HasSumPath](/Assets/hasPathSum.jpg)


