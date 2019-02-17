# Sorting Algorithm
* Insertion Sort

## Challenge
* Write a method tha takes in unsorted array and returns a sorted array using insertion sort

## Approach and Efficiency
1. Created a method for Insertion Sort
> Run a for loop through out the array
- Initialze the value of j to 0
- Set target to array[i] to compare with previous arrays
- If i is greater than 0, j = i -1
> Created a while loop inside the for loop
- Set the target with array[i]
- Set [j + 1 ] to previous
- Reduce j by one and re-run the loop till it hits 0
** Return array

**Efficiency**
- Time Complexity is O(n^2)
- Space Complexity is O(n)


## Solution 
![Shuffle](/Assets/InsertionSort1.jpg)
