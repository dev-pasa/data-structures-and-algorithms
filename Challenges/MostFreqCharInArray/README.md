# Find the most repeated character in a string input


## Challenge
- Create a method that returns the most frequent character from a string input.

## Approach & Efficiency
1. Store all the chars from passed input in an char array
2. Loop through the entire charArray and input it in the dictionary, if the key already exists, increment the value
3. Get the max character
4. Return  the max character

## Solution
![Frequent Char](/Assets/MostFreqChar.jpg)

### Efficiency
* Time Complexity
O(n) as each chars in the array has to be traversed

* Space Complexity
O(n) as a dictonary is created