# Find First Repeated Word
- Find the first repeated word in a string input.

## Challenge
- Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge.

- Ensure your tests are passing before you submit your solution.

## Approach & Efficiency
1. Create an array values whose size equals the input split words 
2. Create an array containing non-words
3. Trim the words inside the values array
4. Input all the values in a hashtable
5. If the hashtable contains the values, return the value
6. If no repeat, return "No Repeat Found"

## Solution
![Repeat Word](/Assets/RepeatWord.jpg)

### Efficiency
* Space Complexity
O(n) 

* Time Complexity
O(n)