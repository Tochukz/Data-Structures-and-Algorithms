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

#### Resources
* [Geeks4Geeks](https://www.geeksforgeeks.org/)  
