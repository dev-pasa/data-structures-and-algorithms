# Left Join on Hash Table
- Output a list that has all the keys and values in one hash table and if the key exists in the second table, return the value else Null.

## Challenge
- Return the keys and values. 
- Ensure your tests are passing before you submit your solution.

## Approach & Efficiency
1. Create a list for the output
2. Run a loop through out the index in the storage
3. Set a tracker for current in the storage nodes
4. Do a while loop till the nodes are not null
5. Create an Array of size 3
6. Check to see if the values exists in the second table
7. If the key exits, add it to the third index of the array
8. Else return Null
9. Return the list. 

## Solution
![LeftJoin](/Assets/LeftJoinHashTable.jpg)
![LeftJoin](/Assets/LeftJoinHashTable2.jpg)

### Efficiency
* Space Complexity
O(n) 

* Time Complexity
O(n)