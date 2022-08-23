# Cracking the Code Interview 4th Edition (2010)
__By Gayle Laakmann__  

[Code Examples](https://www.careercup.com/careercup_book_solutions)  
[CareerCup Resources](https://careercup.com/)

__My Code Examples__  
The original examples in the book was written in Java. I have adapted my own examples for C# and compiled them using the `csi.exe`  

__Using csi to compile C# Code__  
You can use `csi.exe` to interpret C# script file
 * Write you C# code and save it as `.csx` file
 ```
 Console.WriteLine("Hello Work")
 ```
 * Run the script using `csi.exe` like this
 ```
 > "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\Roslyn\csi" myscript.csx
 ```
 * You can also add the `csi.exe` to your path to make the `csi` command available every where so that you can simple do:  
 ```
 >  csi myscript.csx
 ```  

If you are on MacOS, you can install _Visual Studio For Mac_ and `csi` will be available on your terminal.  

 __Why use csi__  
 `csi` will allow you to write top level statement outside of a class method. For example, the following code can be written outside of a class method.
 ```
 Dictionary<int, Student> studentMap = physicsClass.BuildStudents(students);
 foreach(KeyValuePair<int, Student> keyVal in studentMap)
 {
     Console.WriteLine($"{keyVal.Key} => {keyVal.Value.Name}");
 }

 ```
`csi` provides a convenient way of writing a stand alone script in a single file without having to  create a _Visual studio project_.  

 __Java Examples__  
 You can run the Java examples by installing [Java JDK](https://www.oracle.com/java/technologies/downloads) and using the `java` command on you `.java` files.  
 ```
> java Example.java
 ```

____
## Interview Questions
### Part 1: Data Structures
### Chapter 1: Arrays and Strings
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
[Inplace rotate square matrix by 90 degrees](https://www.geeksforgeeks.org/inplace-rotate-square-matrix-by-90-degrees/)
* Exercise 1.7  
[A Boolean Matrix Question](https://www.geeksforgeeks.org/a-boolean-matrix-question/)

__Online Practice__  
* Exercise 1.4  
[Anagram](https://practice.geeksforgeeks.org/problems/anagram-1587115620/1)
* Exercise 1.6  
[Rotate by 90 degree ](https://practice.geeksforgeeks.org/problems/rotate-by-90-degree-1587115621/1)
* Exercise 1.7  
[Boolean Matrix](https://practice.geeksforgeeks.org/problems/boolean-matrix-problem-1587115620/1/)

### Chapter 2: Linked Lists  
A linked list is a linear data structure, in which the elements are not stored at contiguous memory locations. The elements in a linked lists are linked using pointers.  
In simple words, a linked list consists of nodes where each node contains a data field and a reference(link) to the next node in the list.  
A linked list is typically represented by the head of it.

[Linked List MCQ](https://www.geeksforgeeks.org/data-structure-gq/linked-list-gq/)

__Online Solutions__    
* Exercise 2.1  
[Remove duplicates from an unsorted linked list](https://www.geeksforgeeks.org/remove-duplicates-from-an-unsorted-linked-list/)  
* Exercise 2.2  
[Program for n’th node from the end of a Linked List](https://www.geeksforgeeks.org/nth-node-from-the-end-of-a-linked-list/)  
* Exercise 2.3   
[Given only a pointer/reference to a node to be deleted in a singly linked list, how do you delete it?](https://www.geeksforgeeks.org/given-only-a-pointer-to-a-node-to-be-deleted-in-a-singly-linked-list-how-do-you-delete-it/)  
* Exercise 2.5  
[Find first node of loop in a linked list](https://www.geeksforgeeks.org/find-first-node-of-loop-in-a-linked-list/)
* Exercise 2A   
[Reverse a linked list](https://www.geeksforgeeks.org/reverse-a-linked-list/)  
* Exercise 2B (Similar to Exercise 2.4)    
[Add two numbers represented by linked lists](https://www.geeksforgeeks.org/add-two-numbers-represented-by-linked-lists/)  
* Exercise 2C   
[Detect loop in a linked list](https://www.geeksforgeeks.org/detect-loop-in-a-linked-list/)

__Online Practice__  
* Exercise 2.1   
[Remove duplicates from an unsorted linked list](https://practice.geeksforgeeks.org/problems/remove-duplicates-from-an-unsorted-linked-list/1/)  
* Exercise 2.2  
[Nth node from end of linked list](https://practice.geeksforgeeks.org/problems/nth-node-from-end-of-linked-list/1/)  
* Exercise 2.3   
[Delete without head pointer](https://practice.geeksforgeeks.org/problems/delete-without-head-pointer/1/)
* Exercise 2A  
[Reverse a linked list](https://practice.geeksforgeeks.org/problems/reverse-a-linked-list/1/)
* Exercise 2B  
[Add two numbers represented by linked lists](https://practice.geeksforgeeks.org/problems/add-two-numbers-represented-by-linked-lists/1)    
* Exercise 2C   
[Detect Loop in linked list](https://practice.geeksforgeeks.org/problems/detect-loop-in-linked-list/1#)

__Other useful question__  
* [Find the middle of a given linked list](https://www.geeksforgeeks.org/write-a-c-function-to-print-the-middle-of-the-linked-list/?ref=lbp)

### Chapter 3: Stacks and Queues  
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

__Online Practice__  
* Exercise 3.2  
 [Get minimum element from stack](https://practice.geeksforgeeks.org/problems/get-minimum-element-from-stack/1/)  

### Chapter 4: Trees and Graphs  
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

__Depth-First Traversal__  
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
[Level Order Binary Tree Traversal](https://www.geeksforgeeks.org/level-order-tree-traversal/)

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
* Exercise 4.2  
[Find if there is a path between two vertices in a directed graph](https://www.geeksforgeeks.org/find-if-there-is-a-path-between-two-vertices-in-a-given-graph/)
* Exercise 4.3  
[Sorted Array to Balanced BST](https://www.geeksforgeeks.org/sorted-array-to-balanced-bst/)
* Exercise 4.5  
[Inorder Successor in Binary Search Tree](https://www.geeksforgeeks.org/inorder-successor-in-binary-search-tree/)

__Online Resources__  
[Graph Data Structure And Algorithms](https://www.geeksforgeeks.org/graph-data-structure-and-algorithms/)  
[Graph and its representations](https://www.geeksforgeeks.org/graph-and-its-representations/)
[Breadth First Search or BFS for a Graph](https://www.geeksforgeeks.org/breadth-first-search-or-bfs-for-a-graph/)

__Online Practice__  
* Exercise 4.1  
[Check for Balanced Tree](https://practice.geeksforgeeks.org/problems/check-for-balanced-tree/1/)  
* Exercise 4.3  
[Array to BST ](https://practice.geeksforgeeks.org/problems/array-to-bst4443/1/)
Given a sorted array. Convert it into a Height balanced Binary Search Tree (BST). Find the preorder traversal of height balanced BST. If there exist many such balanced BST consider the tree whose preorder is lexicographically smallest.
* Exercise 4.5  
[Inorder Successor in BST](https://practice.geeksforgeeks.org/problems/inorder-successor-in-bst/1/)  
Given a BST, and a reference to a Node x in the BST. Find the Inorder Successor of the given node in the BST.
* Additional Exercise A   
[Level order traversal ](https://practice.geeksforgeeks.org/problems/level-order-traversal/1/)  
Given a binary tree, find its level order traversal.
Level order traversal of a tree is breadth-first traversal for the tree.  
* Additional Exercise B  
[DFS of Graph ](https://practice.geeksforgeeks.org/problems/depth-first-traversal-for-a-graph/1/)  
Given a connected undirected graph. Perform a Depth First Traversal of the graph.
Note: Use recursive approach to find the DFS traversal of the graph starting from the 0th vertex from left to right according to the graph..

### Chapter 7: Object Oriented Design   

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

### Chapter 9: Sorting and Searching
  Algorithm    | Time Complexity
---------------|----------------
Bubble Sort    |    O(n^2)
Selection Sort |    O(n^2)
Merge Sort     |  O(nlog(n))
Quick Sort     |    O(n^2)
Bucket Sort    |    O(n^2)

__Stability in Sorting algorithms__  
A sorting algorithms said to be stable if two objects with equal keys appear in the same order in sorted output as they appear in the input array to be sorted.  

__Which sorting algorithms are stable?__
Bubble sort, Insertion Sort, Merge Sort, Count Sort etc.

__Which sorting algorithms are unstable__  
Quick Sort, Heap Sort etc.  

##### Sorting Algorithms
##### Sorting
__Bubble Sort__  
Bubble sort takes minimum time O(n) when elements are already sorted.  

__Selection Sort__  
The default implementation of selection sort is not stable.   
The good thing about selection sort is it never makes more than O(n) swaps and can be useful when memory write is a costly operation.

__Merge Sort__  
Merge Sort is a _Divide and Conquer_ algorithm It divides the input array into two halves, calls itself for the two halves, and then merges the two sorted halves.  

__Quick Sort__  
The default implementation of Quick Sort is not stable.

__Bucket Sort__  

##### Searching
__Binary Search__  
Binary Search is a `searching algorithm` used in a sorted array by repeatedly dividing the search interval in half. The idea of
binary search is to use the information that the array is sorted and reduce the time complexity to _O(Logn)_.      
Binary search algorithm falls under the _Decrease and Conquer_ paradigm.  

__Online Resources__  
[Sorting Algorithms](https://www.geeksforgeeks.org/sorting-algorithms/)  
[Bubble Sort](https://www.geeksforgeeks.org/bubble-sort/)  
[Selection Sort](https://www.geeksforgeeks.org/selection-sort/)  
[Merge Sort](https://www.geeksforgeeks.org/merge-sort/)  
[Quick Sort](https://www.geeksforgeeks.org/quick-sort/)    
[Searching Algorithms](https://www.geeksforgeeks.org/searching-algorithms/)  
[Binary Search](https://www.geeksforgeeks.org/binary-search/)

__Online Solutions__  
* Exercise 9.1  
[Sorted merge in one array](https://www.geeksforgeeks.org/sorted-merge-one-array/)  
* Exercise 9.2  
[Given a sequence of words, print all anagrams together](https://www.geeksforgeeks.org/given-a-sequence-of-words-print-all-anagrams-together/)

__Online Practice__  
* Exercise 9.2  
[Print Anagrams Together](https://practice.geeksforgeeks.org/problems/print-anagrams-together/1)
* Exercise 9A  
[Punish the Students](https://practice.geeksforgeeks.org/problems/punish-the-students5726/1/)
* Exercise 9B  
[Selection Sort ](https://practice.geeksforgeeks.org/problems/selection-sort/1/#)
* Exercise 9C  
[Merge Sort ](https://practice.geeksforgeeks.org/problems/merge-sort/1/)  
* Exercise 9D  
[Binary Search ](https://practice.geeksforgeeks.org/problems/binary-search/1#)


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
