#Find the Fibonacci number for a given integer

#Challenge
Write a function called Fibonacci which takes in  a integer and returns a fibonacci number to it.
recursively we can do it using fib(n-1) + fib(n -2) but the BigO would be O(2^n) which is very inefficient. 

#Solution
The algorithm I used loops through the number length. The BigO for my solution is O(n). The loop will execute n times until i is greater than n. i starts at zero and increments by 1 every iteration of this loop until n.


Example
Int    =	0	1	2	3	4	5	6	7	8	9	10	11	12	13	14	
------------------------------------------------------------------------
Output =	0	1	1	2	3	5	8	13	21	34	55	89	144	233	377	