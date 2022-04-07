# Cracking the Code Interview 4th Edition (2010)
__By Gayle Laakmann__  

[Code Examples](https://www.careercup.com/careercup_book_solutions)

__My Code Examples__  
The original examples in the book was written in Java. I have adapted my own examples for C# and compiled it using the `csi.exe`  

__Using csi to compile C#__  
You can use `csi.exe` to interpret C# script file
 * Write you C# code and save it as `.csx` file
 ```
 Console.WriteLine("Hello Work")
 ```
 * Run the script using `csi.exe` like this
 ```
 > "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\Roslyn\csi" myscript.csx
 ```
 * You can also add the `csi.exe` to your path to make the `csi` command available every where so that you can simple do.  
 ```
 >  csi myscript.csx
 ```  

 __Why use csi__  
 csi will allow you to write top level statment outside of a class method. For example, the following code can be written outside of a class method.
 ```
 Dictionary<int, Student> studentMap = physicsClass.BuildStudents(students);
 foreach(KeyValuePair<int, Student> keyVal in studentMap)
 {
     Console.WriteLine($"{keyVal.Key} => {keyVal.Value.Name}");
 }

 ```
____
## Interview Questions
### Part 1: Data Structures
#### Chapter 1: Arrays and Strings
__Hash Table__   
A HashTable stores key-value pairs.   
The C# data type for Hash Table is the `Dictionary`, i.e `System.Collections.Generic.Dictionary`.  

__Array List__  
An ArrayList is a dynamically resizing array.  
The C# data type for Array List is `List`, i.e `System.Collections.Generic.List`

__String Buffer__  
The C# data type for String Buffer is `StringBuilder`, i.e `System.Text.StringBuilder`

__Online Resources__   
* [C++ string class and its applications](https://www.geeksforgeeks.org/c-string-class-and-its-applications/)

__Online Solutions__   
* Exercise 1.2  
[Different methods to reverse a string in C/C++](https://www.geeksforgeeks.org/reverse-a-string-in-c-cpp-different-methods/)
* Exercise 1.3  
[Remove Duplicate from a given string](https://www.geeksforgeeks.org/remove-duplicates-from-a-given-string/)
* Exercise 1.4  
[Check whether two strings are anagram of each other](https://www.geeksforgeeks.org/check-whether-two-strings-are-anagram-of-each-other/)
* Exercise 1.5  
[URLify a given string](https://www.geeksforgeeks.org/urlify-a-given-string-replace-spaces-with-%20/)  
* Exercise 1.6  
[Turn an image by 90 degree](https://www.geeksforgeeks.org/turn-an-image-by-90-degree)
* Exercise 1.7  
[A Boolean Matrix Question](https://www.geeksforgeeks.org/a-boolean-matrix-question/)

__Online Exercises__  
* Exercise 1.4  
[Anagram](https://practice.geeksforgeeks.org/problems/anagram-1587115620/1)
* Exercise 1.6  
[Rotate by 90 degree ](https://practice.geeksforgeeks.org/problems/rotate-by-90-degree-1587115621/1)
* Exercise 1.7  
[Boolean Matrix](https://practice.geeksforgeeks.org/problems/boolean-matrix-problem-1587115620/1/)

#### Chapter 2: Linked Lists  
A linked list is a linear data structure, in which the elements are not stored at contiguous memory locations. The elements in a linked lists are linked using pointers.  
In simple words, a linked list consists of nodes where each node contains a data field and a reference(link) to the next node in the list.  
A linked list is typically represented by the head of it.

[Linked List MCQ](https://www.geeksforgeeks.org/data-structure-gq/linked-list-gq/)

__Online Solutions__    
* Exercise 2.2  
[Program for n’th node from the end of a Linked List](https://www.geeksforgeeks.org/nth-node-from-the-end-of-a-linked-list/)  
* Exercise 2.5  
[Find first node of loop in a linked list](https://www.geeksforgeeks.org/find-first-node-of-loop-in-a-linked-list/)

__Other useful question__  
* [Find the middle of a given linked list](https://www.geeksforgeeks.org/write-a-c-function-to-print-the-middle-of-the-linked-list/?ref=lbp)

#### Chapter 3: Stacks and Queues  
__Online Implementations__
* [Stack Data Structure](https://www.geeksforgeeks.org/stack-data-structure-introduction-program/?ref=lbp)  
* [Queue - Array Implementation](https://www.geeksforgeeks.org/queue-set-1introduction-and-array-implementation/?ref=lbp)  
* [Queue – Linked List Implementation](https://www.geeksforgeeks.org/queue-linked-list-implementation/)

__Online Solutions__  
* Exercise 3.1  
 [How to efficiently implement k stacks in a single array?](https://www.geeksforgeeks.org/efficiently-implement-k-stacks-single-array/)
* Exercise 3.2   
[Design and Implement Special Stack Data Structure ](https://www.geeksforgeeks.org/design-and-implement-special-stack-data-structure/)  
[Design a stack that supports getMin() in O(1) time and O(1) extra space](https://www.geeksforgeeks.org/design-a-stack-that-supports-getmin-in-o1-time-and-o1-extra-space/)
* Exercise 3.4  
[Program for Tower of Hanoi](https://www.geeksforgeeks.org/c-program-for-tower-of-hanoi/)  
* Exercise 3.5  
[Queue using Stacks](https://www.geeksforgeeks.org/queue-using-stacks/)

__Online Exercises__  
* Exercise 3.2  
 [Get minimum element from stack](https://practice.geeksforgeeks.org/problems/get-minimum-element-from-stack/1/)  

#### Chapter 4: Trees and Graphs  
##### Tree  
Trees provide moderate access/search which is quicker than Linked List and slower than arrays.
Trees provide moderate insertion/deletion which is quicker than Arrays and slower than Unorders Liked Lists.  
Main uses of tree include maintaining hierarchical data, providing moderate access and insert/delete operations.  

##### Binary Tree  
A tree whose elements have at most 2 children is called a _binary tree_. We typically name them left and right child.  

__Online Implementation__  
[Binary Tree Introduction](https://www.geeksforgeeks.org/binary-tree-set-1-introduction/?ref=lbp)


__Binary Tree Properties__  
1. The maximum numbers of nodes at level l of a binary tree is `2^l`. The root is at level 0.
2. The maximum number of nodes in a binary tree of height h is `2^h - 1`. If the height of the root is considered as 0, it becomes `2^(h+1) - 1`.  
3. In a Binary Tree with N nodes, the minimum possible height or the minimum number of levels is Log2(N+1). If the height of the root node is considered as 0, then it becomes `| Log2 (N+1) | - 1`
4. A Binary tree with L leaves has at least `| Log2 L | + 1` levels
5.

__Tree Traversal__   
Binary Tree Traversal can be:
A. Depth-First Traversal
B. Breath-First Traversal (also known as Level Order Traversal)
Depth-First Transversal can be done in three ways:
1. PreOrder Traversal
2. InOrder Traversal
3. PostOrder Traversal  

__PreOrder Traversal__   
* Visit the root
* Traverse the left subtree
* Travers the right subtree

__InOrder Traversal__   
* Travers the left subtree
* Visit the root
* Traverse the right subtree

__PostOrder Traversal__  
* Traverse the left subtree
* Traverse the right subtree
* Visit the root

[Tree Traversal](https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/?ref=lbp)

##### Binary Search Tree
Binary Search Tree is a node-based binary tree data structure which has the following properties:  
1. The left subtree of a node contains only nodes with keys lesser than the node's key.
2. The right subtree of a node contains only nodes with keys greater then the node's key.
3. The left and right subtree each must also be binary search tree.  
4. There must be no duplicate nodes.  

__Balanced Tree__  
We call a tree balanced if for all nodes the difference between the heights of left and right subtrees is not greater than one.

#####  Graphs
A Graph consists of a finite set of _vertices_ (or nodes) and set of _Edges_ which connect a pair of nodes.  
Graphs are used to represent networks. Graphs are also used in social networks like LinkedIn, Facebook.

The edge of a graph is a pair of ordered vertices (u, v). For _directed graphs (di-graph)_,  (u, v) is not the same as (v, u).   
The most commonly used representations of a graph are:  
1. Adjacency Matrix
2. Adjacency List
There are other representations also like _Incidence Matrix_ and _Incidence List_.

__Online Solutions__  
* Exercise 4.1  
[How to determine if a binary tree is height-balanced?](https://www.geeksforgeeks.org/how-to-determine-if-a-binary-tree-is-balanced/)

__Online Resources__  
[Graph Data Structure And Algorithms](https://www.geeksforgeeks.org/graph-data-structure-and-algorithms/)  
[Graph and its representations](https://www.geeksforgeeks.org/graph-and-its-representations/)

#### Chapter 7: Object Oriented Design   

#### Resources
* [Geeks4Geeks](https://www.geeksforgeeks.org/)  
* [CareerCup](https://careercup.com/)
* [Best Developer Assessment Tools - 2022](https://www.selectsoftwarereviews.com/buyer-guide/online-coding-interview-tools)


#### Developer Assessment Sites
* [hackerrank.com](https://www.hackerrank.com/dashboard)

#### Common Problem Solving Techniques
1. Brute Force
2. Use of a data structure
3. String Manipulation
4. Dynamic Programming
5. Divide-and-conquer

__Brute Force__  
_Brute force_ is a problem solving technique in which all the possible ways or all the possible solutions to a given problem are enumerated. The best solution is then  chosen.   
The Brute force approach is often slow and inefficient.  
__Example__: Implement a SudokuSolver  
__Resource__ : [Brute Force Approach and its pros and cons](https://www.geeksforgeeks.org/brute-force-approach-and-its-pros-and-cons/)  

__Use of Data Structure__  
_Data Structure_ approach produces an optimal solution by using the correct data structure and then writing a basic driver code which utilizes the data structure. This is an efficient approach.  
__Example__: Given an unsorted array of numbers, find 2 elements that sums to K.

__String Manipulation__  
Some problem requires string manipulation.  
__Example__: Given a string containing parenthesis characters, validate that it is a balanced expression of parenthesis.  

__Dynamic Programming__  
Dynamic Programming is mainly an optimization over pain recursion. The idea is to simply store the results of subproblems, so that we do not have to re-compute them then needed later.   
This simple optimization reduces time complexities from exponential to polynomial.   
__Example__: Compute the Fibonacci series for a given n.   
Fibonacci Series: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...  
__Resource__ : [Dynamic Programming](https://www.geeksforgeeks.org/dynamic-programming/)

__Divide-and-Conquer__   
Divide-and-conquer is a problem solving technique where you divide the problem into smaller ones and solve them independently and then construct the solution by combining the various subproblems.
__Example__: Implement a method that combines 2 sorted arrays. Use the method to sort a given array.  
__Resource__ : [Divide and Conquer Algorithm](https://www.geeksforgeeks.org/divide-and-conquer-algorithm-introduction/)  

#### Examples
##### LRU Cache
__Problem Statement__  
In this problem we will focus on coding an in-memory caching component for an existing system.   
Your task is to implement a least recently used (LRU) cache.  

__Basic Definition of LRU Cache__  
It is a data structure of fixed initial capacity of N and if at any moment it is asked to add (N+1)th item, it will remove the least recently used item to accommodate the new one.  

__What operations will it support?__
* get(key)
* insert(key, value)  
