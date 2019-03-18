# Remove duplicates from sorted linked list


## Challenge
- Create a method that removes duplicate node values from the linked list.

## Approach & Efficiency
1. Create a reference to the head
2. Traverse through the linked list
3. If current.next value is same as current value move to the next_next
4. Else keep traversing till the end of linked list.

## Solution
![Remove dupliactes in sorted linked list](/Assets/LinkedListRemoveDuplicates.jpg)

### Efficiency
* Time Complexity
O(n) as each node in the linked list has to be traversed

* Space Complexity
O(n) space is equal to all the nodes in the linked list