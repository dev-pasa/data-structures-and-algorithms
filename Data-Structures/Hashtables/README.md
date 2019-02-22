# Hashtables
- A hash table is a data structure that implements an associative array abstract data type, a structure that can map keys to values. 
- A hash table uses a hashing function to compute an index into an array of buckets.

## Challenge
Creating different methods and testing all the properties. 
Handle any collisions by creating a new node for the key's hash value.
* Add(key, value) - Once the method determines the index of where the key should be placed,, adds key and value to the table
* Get(key) - Takes in a key, gets the Hash, and goes to the index location specified. Returns the value.
* Contains(key) - returns bool, if the key exists in the hash table.
* Hashing(key) - returns array index where the key/value should be placed.

## Approach & Efficiency
1. Add() --> Time complexity O(1), Space Complexity: O(1)
2. Get() --> Time complexity is O(1) on average, O(n) worst case.
3. Contains() --> Time complexity is O(1), Space Complexity: O(1) 
4. Hashing() --> Time Complexity: O(1), Space Complexity: O(1)

## API
<!-- Description of each method publicly available in each of your hashtable -->

## Solution
![Program test](/Assets/hashtable1.jpg)