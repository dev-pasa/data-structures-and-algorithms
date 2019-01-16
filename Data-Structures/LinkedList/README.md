#Singly Linked List

A linked list is a linear data structure where each element is a separate object. Each element (we will call it a node) of a list is comprising of two items - the data and a reference to the next node. The last node has a reference to null. The entry point into a linked list is called the head of the list.

## Challenge
Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
Define a method called print which takes in no arguments and outputs all of the current Node values in the Linked List.


## Approach & Efficiency
The Big O is O(n) to loop through entire list to find the head or the tail. 

## API
The methods that were created are Insert(), Includes(), Append(), Print(), InsertBefore() and InsertAfter().

Insert is to add a node at the head of the list.
Includes is to check of the node is present in the list. 
Append is to add the node at the end of the list. 
Print is to print all the node values in the list. 


#Test
For each method created in the Linked list class, perform three tests.


Reference:
https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/