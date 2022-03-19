# Cracking the Code Interview 4th Edition (2010)
__By Gayle Laakmann__  

[Code Examples](https://www.careercup.com/careercup_book_solutions)

__My Code Examples__  
The original examples in the book was written in Java. I have adapted my own examples for C# and compiled it using the `csi.exe`  

__Using csi to compile C#__  
You can use `csi.exe` to interpret C# script file
 * Write you C# code and save it as `.csx` file
 ```
 Console.WriteLIne("Hello Work")
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

__Online Solutions__  
* Exercise 1.4 -> [Check whether two strings are anagram of each other](https://www.geeksforgeeks.org/check-whether-two-strings-are-anagram-of-each-other/)
#### Chapter 2: Linked Lists  
A linked list is a linear data structure, in which the elements are not stored at contiguous memory locations. The elements in a linked lists are linked using pointers.  
In simple words, a linked list consists of nodes where each node contains a data field and a reference(link) to the next node in the list.  
A linked list is typically represented by the head of it.

[Linked List MCQ](https://www.geeksforgeeks.org/data-structure-gq/linked-list-gq/)

__Online Solutions__    
* Exercise 2.2 -> [Program for n’th node from the end of a Linked List](https://www.geeksforgeeks.org/nth-node-from-the-end-of-a-linked-list/)  

__Other useful question__  
* [Find the middle of a given linked list](https://www.geeksforgeeks.org/write-a-c-function-to-print-the-middle-of-the-linked-list/?ref=lbp)


#### Chapter 3: Stacks and Queues  
__Online Implementations__
* [Stack Data Structure](https://www.geeksforgeeks.org/stack-data-structure-introduction-program/?ref=lbp)  
* [Queue - Array Implementation](https://www.geeksforgeeks.org/queue-set-1introduction-and-array-implementation/?ref=lbp)  
*[Queue – Linked List Implementation](https://www.geeksforgeeks.org/queue-linked-list-implementation/)

__Online Solutions__  
* Exercise 3.1 -> [How to efficiently implement k stacks in a single array?](https://www.geeksforgeeks.org/efficiently-implement-k-stacks-single-array/)

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
#### Resources
* [Geeks4Geeks](https://www.geeksforgeeks.org/)  
* [CareerCup](https://careercup.com/)
* [Best Developer Assessment Tools - 2022](https://www.selectsoftwarereviews.com/buyer-guide/online-coding-interview-tools)

#### Developer Assessment Sites
* [hackerrank.com](https://www.hackerrank.com/dashboard)
